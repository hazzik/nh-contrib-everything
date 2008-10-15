using System;
using NHibernate.Cfg;
using NHibernate.Event;
using NHibernate.Search.Backend;
using NHibernate.Search.Engine;
using NHibernate.Search.Impl;

namespace NHibernate.Search.Event
{
    public class FullTextIndexEventListener : IPostDeleteEventListener, IPostInsertEventListener,
                                              IPostUpdateEventListener,
                                              IInitializable
    {
        protected bool used;
        protected ISearchFactoryImplementor searchFactory;

        #region Property methods

        public ISearchFactoryImplementor SearchFactory
        {
            get { return searchFactory; }
        }

        #endregion

        #region Private methods

        private bool EntityIsIndexed(object entity)
        {
            DocumentBuilder builder;
            searchFactory.DocumentBuilders.TryGetValue(entity.GetType(), out builder);
            return builder != null;
        }

        #endregion

        #region Protected methods

        /// <summary>
        /// Does the work, after checking that the entity type is indeed indexed.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <param name="workType"></param>
        /// <param name="e"></param>
        protected void ProcessWork(Object entity, object id, WorkType workType, AbstractEvent e)
        {
            if (EntityIsIndexed(entity))
            {
                Work work = new Work(entity, id, workType);
                searchFactory.Worker.PerformWork(work, e.Session);
            }
        }

        #endregion

        #region Public methods

        public void Initialize(Configuration cfg)
        {
            searchFactory = SearchFactoryImpl.GetSearchFactory(cfg);

            String indexingStrategy = cfg.GetProperty(Environment.IndexingStrategy);
            if (indexingStrategy == null)
                indexingStrategy = "event";
            if ("event".Equals(indexingStrategy)) used = searchFactory.DocumentBuilders.Count != 0;
            else if ("manual".Equals(indexingStrategy)) used = false;
            else throw new SearchException(Environment.IndexBase + " unknown: " + indexingStrategy);
        }

        public void OnPostDelete(PostDeleteEvent e)
        {
            if (used)
                ProcessWork(e.Entity, e.Id, WorkType.Delete, e);
        }

        public void OnPostInsert(PostInsertEvent e)
        {
            if (used)
                ProcessWork(e.Entity, e.Id, WorkType.Add, e);
        }

        public void OnPostUpdate(PostUpdateEvent e)
        {
            if (used)
                ProcessWork(e.Entity, e.Id, WorkType.Update, e);
        }

        #endregion
    }
}