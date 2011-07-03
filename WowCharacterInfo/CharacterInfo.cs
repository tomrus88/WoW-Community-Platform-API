using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace WowCharacterInfo
{
    class CharacterInfo
    {
        const string baseURL = "http://{0}.battle.net/api/wow/character/{1}/{2}";

        public static Character Get(string region, string realm, string character)
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

                    var serializer = new DataContractJsonSerializer(typeof(Character));
                    return (Character)serializer.ReadObject(client.OpenRead(new Uri(String.Format(baseURL, region, realm, character) + "?fields=items,talents,mounts,titles,pets,stats,reputation,achievements")));
                }
                catch (WebException web)
                {
                    var stream = web.Response.GetResponseStream();
                    var buffer = new byte[1024];
                    var read = stream.Read(buffer, 0, buffer.Length);
                    var dataStr = Encoding.UTF8.GetString(buffer, 0, read);

                    var serializer = new JavaScriptSerializer();
                    return serializer.Deserialize<Character>(dataStr);
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
