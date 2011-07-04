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
            using (WebClient client = new WebClient())
            {
                try
                {
                    var serializer = new DataContractJsonSerializer(typeof(Character));
                    return (Character)serializer.ReadObject(client.OpenRead(new Uri(String.Format(baseURL, region, realm, character) + "?fields=items,talents,mounts,titles,pets,stats,reputation,achievements,companions,professions,guild,appearance,progression")));
                }
                catch (WebException web)
                {
                    var stream = web.Response.GetResponseStream();
                    var serializer = new DataContractJsonSerializer(typeof(Character));
                    return (Character)serializer.ReadObject(stream);
                }
                catch (Exception exc)
                {
                    exc.ToString();
                    return null;
                }
            }
        }
    }
}
