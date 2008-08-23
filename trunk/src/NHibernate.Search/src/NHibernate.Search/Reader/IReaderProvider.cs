using System.Collections.Generic;
using Lucene.Net.Index;
using NHibernate.Search.Engine;
using NHibernate.Search.Store;

namespace NHibernate.Search.Reader
{
    /// <summary>
    /// Responsible for providing and managing the lifecycle of a read-only reader
    /// <para>
    /// Note that the reader must be closed once opened.
    /// The ReaderProvider implementation must have a no-arg constructor
    /// </para>
    /// </summary>
    public interface IReaderProvider
    {
        IndexReader OpenReader(IDirectoryProvider[] directoryProviders);

        void CloseReader(IndexReader reader);

        void Initialize(IDictionary<string, string> properties, ISearchFactoryImplementor searchFactoryImplementor);
    }
}