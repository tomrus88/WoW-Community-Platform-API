using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class RecipeData
    {
        #pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "profession")]
        public string Profession { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        #pragma warning restore 0649

        const string baseURL = "http://{0}.battle.net/api/wow/recipe/{1}";

        public static RecipeData Get(string region, int id, Locale? locale = null)
        {
            string url = String.Format(baseURL, region, id);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<RecipeData>(url);
        }
    }
}
