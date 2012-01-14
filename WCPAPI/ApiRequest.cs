using System;
using System.Net;
using System.Runtime.Serialization.Json;

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
                    return (T)serializer.ReadObject(webResponse.GetResponseStream());
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
                            return null;

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
}
