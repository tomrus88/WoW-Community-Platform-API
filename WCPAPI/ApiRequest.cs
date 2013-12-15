using System;
using System.Drawing;
using System.Net;
using System.Runtime.Serialization.Json;

namespace WCPAPI
{
    public class DataNotModifieldException : Exception
    {
        public DataNotModifieldException(string message)
            : base(message)
        {

        }
    }

    public class DataNotFoundException : Exception
    {
        public DataNotFoundException(string message)
            : base(message)
        {

        }
    }

    public class DataErrorException : Exception
    {
        public DataErrorException(object data)
            : base()
        {
            Data.Add("error", data);
        }
    }

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

    public class ApiRequest
    {
        public T Get<T>(string url, DateTime? ifModifiedSince = null) where T : class
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
                            throw new DataNotFoundException("NotFound");

                        if (resp.StatusCode == HttpStatusCode.InternalServerError)
                        {
                            var serializer = new DataContractJsonSerializer(typeof(ApiError));
                            var error = serializer.ReadObject(resp.GetResponseStream());
                            throw new DataErrorException(error);
                        }

                        if (resp.StatusCode == HttpStatusCode.NotModified)
                        {
                            throw new DataNotModifieldException("NotModified");
                            //return null; // grab from the cache?
                            //return (T)DataCache.Get(key);
                        }
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public Bitmap GetIcon(string url)
        {
            HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            webRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            try
            {
                using (HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse)
                {
                    return new Bitmap(webResponse.GetResponseStream());
                    //DataCache.Add(result.GetHashCode().ToString(), result);
                }
            }
            catch (WebException)
            {
                return null;
            }
        }
    }
}
