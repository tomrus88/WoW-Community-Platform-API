using System;
using System.Net;
using System.Runtime.Serialization.Json;

namespace WowGuildInfo
{
    public class GuildInfo
    {
        const string baseURL = "http://{0}.battle.net/api/wow/guild/{1}/{2}";

        public static Guild Get(string region, string realm, string guild)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var serializer = new DataContractJsonSerializer(typeof(Guild));
                    return (Guild)serializer.ReadObject(client.OpenRead(new Uri(String.Format(baseURL, region, realm, guild) + "?fields=members,achievements")));
                }
                catch (WebException web)
                {
                    var serializer = new DataContractJsonSerializer(typeof(Guild));
                    return (Guild)serializer.ReadObject(web.Response.GetResponseStream());
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
