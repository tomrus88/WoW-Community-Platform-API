using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace WowRealmStatus
{
    class RealmStatus
    {
        public List<Realm> realms = new List<Realm>();

        const string baseURL = "http://{0}.battle.net/api/wow/realm/status{1}";

        public static RealmStatus Get(string region, params object[] realms)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string args = String.Empty;

                    if (realms.Length != 0)
                    {
                        args = String.Format("?realm={0}", realms[0]);

                        for (var i = 1; i < realms.Length; ++i)
                            args += String.Format("&realm={0}", realms[i]);
                    }

                    byte[] data = client.DownloadData(new Uri(String.Format(baseURL, region, args)));

                    var dataStr = Encoding.UTF8.GetString(data);

                    var serializer = new JavaScriptSerializer();

                    return serializer.Deserialize<RealmStatus>(dataStr);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
