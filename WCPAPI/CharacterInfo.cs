using System;
using System.Net;
using System.Runtime.Serialization.Json;

namespace WCPAPI
{
    public class CharacterInfo
    {
        const string baseURL = "http://{0}.battle.net/api/wow/character/{1}/{2}";

        public static Character Get(string region, string realm, string character)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var serializer = new DataContractJsonSerializer(typeof(Character));
                    return (Character)serializer.ReadObject(client.OpenRead(new Uri(String.Format(baseURL, region, realm, character) + "?fields=items,talents,mounts,titles,pets,stats,reputation,achievements,companions,professions,guild,appearance,progression")));
                }
                catch (WebException web)
                {
                    var serializer = new DataContractJsonSerializer(typeof(Character));
                    return (Character)serializer.ReadObject(web.Response.GetResponseStream());
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
