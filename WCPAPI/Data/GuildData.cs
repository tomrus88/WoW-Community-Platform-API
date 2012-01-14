using System;
using System.Collections.Generic;
using System.Linq;

namespace WCPAPI
{
    public class GuildData
    {
        const string baseURL = "http://{0}.battle.net/api/wow/guild/{1}/{2}";

        public static Guild Get(string region, string realm, string guild, GuildFields? fields = null, Locale? locale = null)
        {
            string url = String.Format(baseURL, region, realm, guild);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (fields.HasValue)
                parameters.Add("fields", FieldsFromEnum(fields.Value));

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<Guild>(url);
        }

        private static string FieldsFromEnum(GuildFields flagsEnum)
        {
            int flagsValue = Convert.ToInt32(flagsEnum);

            var values = Enum.GetValues(flagsEnum.GetType()).Cast<int>().Where(x => (flagsValue & x) == x)
                    .Except(new[] { 0x0, 0x3, 0x7FFFFFFF }).Select(x => Enum.GetName(flagsEnum.GetType(), x).ToString()).ToArray();

            return string.Join(",", values).ToLowerInvariant();
        }
    }
}
