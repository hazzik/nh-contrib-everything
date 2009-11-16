using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NHibernate.JetDriver.Tests.Entities;
using NUnit.Framework.SyntaxHelpers;

namespace NHibernate.JetDriver.Tests
{
    [TestFixture]
    public class JetHQLFixture : JetTestBase
    {
        public JetHQLFixture() : base(true)
        {
        }

        protected override IList<System.Type> EntityTypes
        {
            get 
            { 
                return new[]
                           {
                               typeof(Foo),
                               typeof(ReportDTO),
                               typeof(Catalog),
                               typeof(Category), 
                               typeof(ProductType),
                               typeof(Product),
                           }; 
            }
        }

        [Test]
        public void Can_Delete_Objects_With_HQL()
        {
            object savedId;
            using (var s = SessionFactory.OpenSession())
            using (var t = s.BeginTransaction())
            {
                savedId = s.Save(new Foo
                {
                    ModuleId = -1,
                    Module = "bar"
                });

                t.Commit();
            }

            using (var s = SessionFactory.OpenSession())
            using (var t = s.BeginTransaction())
            {
                var m = s.Get<Foo>(savedId);
                m.Module = "bar2";
                t.Commit();
            }

            //delete using a HQL statement
            using (var s = SessionFactory.OpenSession())
            using (var t = s.BeginTransaction())
            {
                var m = s.Get<Foo>(savedId);

                s.Delete("from Foo foo where foo.ModuleId = ?",
                         m.ModuleId, NHibernateUtil.Int32);

                t.Commit();
            }

            using (var s = SessionFactory.OpenSession())
            using (var t = s.BeginTransaction())
            {
                s.CreateQuery("delete from Foo").ExecuteUpdate();
                t.Commit();
            }
        }

        [Test]
        public void Select_With_HQL_Will_Not_Emit_Two_From_Clauses()
        {
            using (var s = SessionFactory.OpenSession())
            {
                string hql = @"select new ReportDTO (
                               c.Id,
                               c.Category.Id, c.Category.Name,
                               c.ProductType.Id, c.ProductType.Name) 
                               from Catalog c
                               where c.Category.Product.Id=:productId";

                IQuery query = s.CreateQuery(hql);
                query.SetParameter("productId", 5);
                var list = query.List();
                int count = list.Count;

                Assert.That(count, Is.EqualTo(0));
            }
        }
    }
}