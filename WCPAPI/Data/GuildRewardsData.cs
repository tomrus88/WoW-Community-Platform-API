using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class GuildRewardsData
    {
        #pragma warning disable 0649
        [DataMember(Name = "rewards")]
        public GuildReward[] Rewards;
        #pragma warning restore 0649

        const string baseURL = "http://{0}.battle.net/api/wow/data/guild/rewards";

        public static GuildRewardsData Get(string region, Locale? locale = null)
        {
            string url = String.Format(baseURL, region);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<GuildRewardsData>(url);
        }
    }

    [DataContract]
    public class GuildReward
    {
        //[DataMember(Name = "id")]
        //public int Id;
        //[DataMember(Name = "mask")]
        //public int Mask;
        //[DataMember(Name = "powerType")]
        //public string PowerType;
        //[DataMember(Name = "name")]
        //public string Name;
    }
}
