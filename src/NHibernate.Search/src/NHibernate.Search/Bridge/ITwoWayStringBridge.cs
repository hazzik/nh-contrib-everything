using System;

namespace NHibernate.Search.Bridge {
    public interface ITwoWayStringBridge : IStringBridge {
        /// <summary>
        /// Convert the string representation to an object
        /// </summary>
        Object StringToObject(String stringValue);
    }
}