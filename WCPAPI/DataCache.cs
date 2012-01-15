using System;
using System.Web;
using System.Web.Caching;

namespace WCPAPI
{
    public static class DataCache
    {
        public static object Get(string key)
        {
            return HttpRuntime.Cache.Get(key);
        }

        public static void Add(string key, object value)
        {
            HttpRuntime.Cache.Add(key, value, null, DateTime.Now.AddDays(1), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }
    }
}
