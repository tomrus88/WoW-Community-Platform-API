using System;
using System.Collections.Generic;
using System.Linq;

namespace WCPAPI
{
    public class CharacterData
    {
        const string baseURL = "http://{0}.battle.net/api/wow/character/{1}/{2}";

        public static Character Get(string region, string realm, string character, CharacterFields? fields = null, Locale? locale = null)
        {
            string url = String.Format(baseURL, region, realm, character);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (fields.HasValue)
                parameters.Add("fields", FieldsFromEnum(fields.Value));

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return ApiRequest.Get<Character>(url);
        }

        private static string FieldsFromEnum(CharacterFields flagsEnum)
        {
            int flagsValue = Convert.ToInt32(flagsEnum);

            var values = Enum.GetValues(flagsEnum.GetType()).Cast<int>().Where(x => (flagsValue & x) == x)
                    .Except(new[] { 0x0, 0x7FFF, 0x7FFFFFFF }).Select(x => Enum.GetName(flagsEnum.GetType(), x).ToString()).ToArray();

            return string.Join(",", values).ToLowerInvariant();
        }
    }
}
