using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class GuildPerksData
    {
        #pragma warning disable 0649
        [DataMember(Name = "perks")]
        public GuildPerk[] Perks;
        #pragma warning restore 0649

        const string baseURL = "http://{0}.battle.net/api/wow/data/guild/perks";

        public static GuildPerksData Get(string region, Locale? locale = null)
        {
            string url = String.Format(baseURL, region);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<GuildPerksData>(url);
        }
    }

    [DataContract]
    public class GuildPerk
    {
        [DataMember(Name = "guildLevel")]
        public int GuildLevel;
        [DataMember(Name = "spell")]
        public SpellInfo Spell;
    }
}
