﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using log4net;
using System.Reflection;
using NHibernate.Connection;
using NHibernate.Driver;
using System.Data;
using System.Data.Common;
using System.IO;

namespace NHibernate.Tool.Db2hbm
{
    public class MappingGenerator
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        db2hbmconf cfg;
        IList<IMetadataStrategy> metaStrategies;
        public MappingGenerator()
        {
            metaStrategies = new List<IMetadataStrategy>();
            metaStrategies.Add(new FirstPassEntityCollector());
        }
        public void Configure(XmlReader reader)
        {
            XmlDocument cfgdoc = new XmlDocument();
            cfgdoc.Load(reader);
            Validate(cfgdoc);
            XmlSerializer ser = new XmlSerializer(typeof(db2hbmconf));
            this.cfg = ser.Deserialize(XmlReader.Create(new StringReader(cfgdoc.InnerXml))) as db2hbmconf;
        }
        public void Generate(IStreamProvider streamProvider)
        {
            GenerationContext ctx = new GenerationContext();
            ctx.Dialect = GetDialect();
            ctx.Model = new MappingModelImpl();
            IDriver driver = GetDriver();
            try
            {
                using (IDbConnection connection = driver.CreateConnection())
                {
                    DbConnection dbConn = connection as DbConnection;
                    if (null == dbConn)
                        throw new Exception("Can't convert connection provided by driver to DbConnection");
                    connection.ConnectionString = cfg.connectioninfo.connectionstring;
                    connection.Open();
                    ctx.Schema = ctx.Dialect.GetDataBaseSchema(dbConn);
                    ctx.Configuration = cfg;
                    ctx.Connection = dbConn;
                    foreach (IMetadataStrategy strategy in metaStrategies)
                        strategy.Process(ctx);
                }
                
                foreach (var clazz in ctx.Model.GetEntities())
                {
                    TextWriter target = streamProvider.GetTextWriter(clazz.name);
                    hibernatemapping mapping = new hibernatemapping();
                    mapping.Items = new object[] { clazz };
                    if (!string.IsNullOrEmpty(cfg.entitiesnamespace))
                        mapping.@namespace = cfg.entitiesnamespace;
                    if (!string.IsNullOrEmpty(cfg.entitiesassembly))
                        mapping.assembly = cfg.entitiesassembly;
                    XmlSerializer ser = new XmlSerializer(typeof(hibernatemapping));
                    XmlSerializerNamespaces empty = new XmlSerializerNamespaces();
                    empty.Add(string.Empty, "urn:nhibernate-mapping-2.2");
                    ser.Serialize(target, mapping,empty);
                    target.Flush();
                    target.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private IDriver GetDriver()
        {
            if (string.IsNullOrEmpty(cfg.connectioninfo.connectiondriver))
            {
                throw new Exception("Connection driver must be specified");
            }
            System.Type tDriver = System.Type.GetType(cfg.connectioninfo.connectiondriver);
            if (null == tDriver)
                throw new Exception("Cannot create driver:" + cfg.connectioninfo.connectiondriver);
            if (!typeof(IDriver).IsAssignableFrom(tDriver))
                throw new Exception("Driver:" + cfg.connectioninfo.connectiondriver + " is not a valid driver.");
            IDriver driver = Activator.CreateInstance(tDriver) as IDriver;
            if (null == driver)
            {
                throw new Exception("Cannot instantiate:" + cfg.connectioninfo.connectiondriver+ " driver");
            }
            return driver;
        }

        private NHibernate.Dialect.Dialect GetDialect()
        {
            if (string.IsNullOrEmpty ( cfg.connectioninfo.dialect))
            {
                throw new Exception("Dialect must be specified");
            }
            System.Type tDialect = System.Type.GetType(cfg.connectioninfo.dialect);
            if (null == tDialect)
                throw new Exception("Cannot create dialect:" + cfg.connectioninfo.dialect);
            if( !typeof(NHibernate.Dialect.Dialect).IsAssignableFrom(tDialect) )
                throw new Exception("Dialect:" + cfg.connectioninfo.dialect+" is not a valid dialect.");
            NHibernate.Dialect.Dialect dialect = Activator.CreateInstance(tDialect) as NHibernate.Dialect.Dialect;
            if (null == dialect)
            {
                throw new Exception("Cannot instantiate:" + cfg.connectioninfo.dialect+" dialect");
            }
            return dialect;
        }
        private void Validate(XmlDocument cfg)
        {
            var cv = new ConfigurationValidator();
            cv.Validate(cfg);
            log.Warn(cv.WarningMessage);
        }
    }
}
