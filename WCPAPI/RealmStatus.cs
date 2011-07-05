using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace WCPAPI
{
    [DataContract]
    public class RealmStatus
    {
        [DataMember(Name = "realms")]
        public IList<Realm> Realms { get; private set; }

        const string baseURL = "http://{0}.battle.net/api/wow/realm/status{1}";
        //const string baseURLCN = "http://battlenet.com.cn/api/wow/realm/status{1}";

        public static RealmStatus Get(string region, params object[] realms)
        {
            using (var client = new WebClient())
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

                    var serializer = new DataContractJsonSerializer(typeof(RealmStatus));

                    return (RealmStatus)serializer.ReadObject(client.OpenRead(new Uri(String.Format(baseURL, region, args))));
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
