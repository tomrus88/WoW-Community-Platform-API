using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace WowCharacterInfo
{
    class Character
    {
        const string baseURL = "http://{0}.battle.net/api/wow/character/{1}/{2}";

        public static Character Get(string region, string realm, string character)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    byte[] data;

                    string args = String.Empty;

                    data = client.DownloadData(new Uri(String.Format(baseURL, region, realm, character)));

                    var dataStr = Encoding.UTF8.GetString(data);

                    var serializer = new JavaScriptSerializer();

                    return serializer.Deserialize<Character>(dataStr);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
