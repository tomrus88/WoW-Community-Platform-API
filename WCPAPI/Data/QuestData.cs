using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class QuestData
    {
        #pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "title")]
        public string Title { get; private set; }
        [DataMember(Name = "reqLevel")]
        public int ReqLevel { get; private set; }
        [DataMember(Name = "suggestedPartyMembers")]
        public int SuggestedPartyMembers { get; private set; }
        [DataMember(Name = "category")]
        public string Category { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        #pragma warning restore 0649

        const string baseURL = "http://{0}.battle.net/api/wow/quest/{1}";

        public static QuestData Get(string region, int id, Locale? locale = null)
        {
            string url = String.Format(baseURL, region, id);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<QuestData>(url);
        }
    }
}
