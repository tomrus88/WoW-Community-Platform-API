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
        const string realmArg = "realm={0}{1}";

        public static RealmStatus Get(string region, params object[] realms)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    byte[] data;

                    string args = String.Empty;

                    if (realms.Length != 0)
                    {
                        args += "?";
                        for (var i = 0; i < realms.Length; ++i)
                            args += String.Format(realmArg, realms[i], i + 1 == realms.Length ? String.Empty : "&");
                    }

                    data = client.DownloadData(new Uri(String.Format(baseURL, region, args)));

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
