using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace WowGuildInfo
{
    public class GuildInfo
    {
        const string baseURL = "http://{0}.battle.net/api/wow/guild/{1}/{2}";

        public static Guild Get(string region, string realm, string guild)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    //byte[] data = client.DownloadData(new Uri(String.Format(baseURL, region, realm, character)));

                    //var dataStr = Encoding.UTF8.GetString(data);

                    //File.WriteAllText("char.txt", dataStr);

                    //var serializer = new JavaScriptSerializer();

                    //return serializer.Deserialize<Character>(dataStr);

                    var serializer = new DataContractJsonSerializer(typeof(Guild));
                    return (Guild)serializer.ReadObject(client.OpenRead(new Uri(String.Format(baseURL, region, realm, guild) + "?fields=members,achievements")));
                }
                catch (WebException web)
                {
                    var stream = web.Response.GetResponseStream();
                    var buffer = new byte[1024];
                    var read = stream.Read(buffer, 0, buffer.Length);
                    var dataStr = Encoding.UTF8.GetString(buffer, 0, read);

                    var serializer = new JavaScriptSerializer();
                    return serializer.Deserialize<Guild>(dataStr);
                }
                catch (Exception exc)
                {
                    exc.ToString();
                    return null;
                }
            }
        }
    }
}
