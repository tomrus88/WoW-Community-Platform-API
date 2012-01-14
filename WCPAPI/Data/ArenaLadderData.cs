using System;
using System.Collections.Generic;
using System.Linq;

namespace WCPAPI
{
    public class ArenaLadderData
    {
        const string baseURL = "http://{0}.battle.net/api/wow/pvp/arena/{1}/{2}";

        public static ArenaLadder Get(string region, string bg, string size, int count = 0, Locale? locale = null)
        {
            string url = String.Format(baseURL, region, bg, size);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != 0)
                parameters.Add("size", count.ToString());

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<ArenaLadder>(url);
        }
    }
}
