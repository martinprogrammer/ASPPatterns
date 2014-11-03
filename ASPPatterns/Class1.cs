using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPPatterns
{
    public class NullObjectCache :ICacheStorage
    {
        public void Remove(string key)
        {
            
        }

        public void Store(string key, object data)
        {
            
        }

        public T Retrieve<T>(string key)
        {
            return default(T);
        }
    }
}