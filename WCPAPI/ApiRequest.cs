using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Caching;
using System.Web;

namespace WCPAPI
{
    public enum Locale
    {
        en_US,
        es_MX,
        en_GB,
        fr_FR,
        ru_RU,
        de_DE,
        ko_KR,
        zh_TW,
        zh_CN,
        pt_PT,
        pt_BR
    }

    public static class ApiRequest
    {
        public static T Get<T>(string url, DateTime? ifModifiedSince = null) where T : class
        {
            HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            webRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            if (ifModifiedSince.HasValue)
                webRequest.IfModifiedSince = ifModifiedSince.Value;

            try
            {
                using (HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse)
                {
                    var serializer = new DataContractJsonSerializer(typeof(T));
                    T result = (T)serializer.ReadObject(webResponse.GetResponseStream());
                    //DataCache.Add(result.GetHashCode().ToString(), result);
                    return result;
                }
            }
            catch (WebException web)
            {
                if (web.Status == WebExceptionStatus.ProtocolError)
                {
                    if (web.Response != null)
                    {
                        var resp = web.Response as HttpWebResponse;

                        if (resp.StatusCode == HttpStatusCode.NotFound)
                            return null;

                        if (resp.StatusCode == HttpStatusCode.NotModified)
                        {
                            return null; // grab from the cache?
                            //return (T)DataCache.Get(key);
                        }

                        var serializer = new DataContractJsonSerializer(typeof(T));
                        return (T)serializer.ReadObject(resp.GetResponseStream());
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }

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
