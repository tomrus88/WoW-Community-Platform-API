using System;
using System.Collections.Generic;
using System.Linq;

namespace WCPAPI
{
    public class ItemData
    {
        const string baseURL = "http://{0}.battle.net/api/wow/item/{1}";

        public static Item Get(string region, int id, Locale? locale = null)
        {
            string url = String.Format(baseURL, region, id);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<Item>(url);
        }
    }
}
