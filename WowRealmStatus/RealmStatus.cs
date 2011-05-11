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

        public static RealmStatus GetAll(string region)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    var data = client.DownloadData(new Uri(String.Format("http://{0}.battle.net/api/wow/realm/status", region)));

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

        public static RealmStatus GetSingle(string region, string realm)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    var data = client.DownloadData(new Uri(String.Format("http://{0}.battle.net/api/wow/realm/status?realm={1}", region, realm)));

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
