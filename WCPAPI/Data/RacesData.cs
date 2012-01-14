using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class RacesData
    {
        #pragma warning disable 0649
        [DataMember(Name = "races")]
        public Race[] Races { get; private set; }
        #pragma warning restore 0649

        const string baseURL = "http://{0}.battle.net/api/wow/data/character/races";

        public static RacesData Get(string region, Locale? locale = null)
        {
            string url = String.Format(baseURL, region);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<RacesData>(url);
        }
    }

    [DataContract]
    public class Race
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "mask")]
        public int Mask { get; private set; }
        [DataMember(Name = "side")]
        public string Side { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
    }
}
