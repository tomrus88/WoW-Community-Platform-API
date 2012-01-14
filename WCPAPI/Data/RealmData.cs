using System;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class RealmData
    {
        [DataMember(Name = "realms")]
        public Realm[] Realms { get; private set; }

        const string baseURL = "http://{0}.battle.net/api/wow/realm/status{1}";

        public static RealmData Get(string region, params object[] realms)
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

                return ApiRequest.Get<RealmData>(String.Format(baseURL, region, args));
            }
            catch
            {
                return null;
            }
        }
    }
}
