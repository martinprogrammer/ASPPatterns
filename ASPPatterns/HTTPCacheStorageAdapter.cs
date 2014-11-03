using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPPatterns
{
    public class HTTPCacheStorageAdapter : ICacheStorage
    {
        private HttpContext _context;

        public HTTPCacheStorageAdapter()
        {
            _context = HttpContext.Current;
        }
        public void Remove(string key)
        {
            _context.Cache.Remove(key);
        }

        public void Store(string key, object data)
        {
            _context.Cache.Insert(key,data);
        }

        public T Retrieve<T>(string key)
        {
            T itemStored = (T)_context.Cache.Get(key);
            return itemStored;
        }
    }
}