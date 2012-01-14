using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace WCPAPI
{
    public class ItemData
    {
        const string baseURL = "http://{0}.battle.net/api/wow/item/{1}";

        public static Item Get(string region, int id)
        {
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;

                try
                {
                    var serializer = new DataContractJsonSerializer(typeof(Item));
                    return (Item)serializer.ReadObject(client.OpenRead(new Uri(String.Format(baseURL, region, id))));
                }
                catch (WebException web)
                {
                    var serializer = new DataContractJsonSerializer(typeof(Item));
                    return (Item)serializer.ReadObject(web.Response.GetResponseStream());
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
