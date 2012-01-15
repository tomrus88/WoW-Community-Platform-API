using System;
using System.Collections.Generic;
using System.Linq;

namespace WCPAPI
{
    public class ApiClient
    {
        private ApiRequest m_request;
        public string Region { get; set; }
        private const string baseUrl = "http://{0}.battle.net/api/wow/{1}";

        public ApiClient(string region)
        {
            Region = region;

            m_request = new ApiRequest();
        }

        public T Get<T>(string path, Dictionary<string, string> args = null, Locale? locale = null) where T : class
        {
            string url = string.Format(baseUrl, Region, path);

            Dictionary<string, string> parameters = args ?? new Dictionary<string, string>();

            if (locale.HasValue)
                parameters.Add("locale", locale.Value.ToString());

            if (parameters.Count != 0)
                url += "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray());

            return m_request.Get<T>(url);
        }

        public Item GetItem(int id, Locale? locale = null)
        {
            return Get<Item>(string.Format("item/{0}", id), null, locale);
        }

        public ArenaLadder GetArenaLadder(string bg, string size, int count = 0, Locale? locale = null)
        {
            if (count != 0)
            {
                var parameters = new Dictionary<string, string> { { "size", count.ToString() } };
                return Get<ArenaLadder>(string.Format("pvp/arena/{0}/{1}", bg, size), parameters, locale);
            }
            else
            {
                return Get<ArenaLadder>(string.Format("pvp/arena/{0}/{1}", bg, size), null, locale);
            }
        }

        public Character GetCharacter(string realm, string character, CharacterFields? fields = null, Locale? locale = null)
        {
            if (fields.HasValue)
            {
                Dictionary<string, string> parameters = new Dictionary<string, string> { { "fields", FieldsFromEnum1(fields.Value) } };
                return Get<Character>(string.Format("character/{0}/{1}", realm, character), parameters, locale);
            }
            else
            {
                return Get<Character>(string.Format("character/{0}/{1}", realm, character), null, locale);
            }
        }

        private static string FieldsFromEnum1(CharacterFields flagsEnum)
        {
            int flagsValue = Convert.ToInt32(flagsEnum);

            var values = Enum.GetValues(flagsEnum.GetType()).Cast<int>().Where(x => (flagsValue & x) == x)
                    .Except(new[] { 0x0, 0x7FFF, 0x7FFFFFFF }).Select(x => Enum.GetName(flagsEnum.GetType(), x).ToString()).ToArray();

            return string.Join(",", values).ToLowerInvariant();
        }

        public Guild GetGuild(string realm, string guild, GuildFields? fields = null, Locale? locale = null)
        {
            if (fields.HasValue)
            {
                Dictionary<string, string> parameters = new Dictionary<string, string> { { "fields", FieldsFromEnum2(fields.Value) } };
                return Get<Guild>(string.Format("guild/{0}/{1}", realm, guild), parameters, locale);
            }
            else
            {
                return Get<Guild>(string.Format("guild/{0}/{1}", realm, guild), null, locale);
            }
        }

        private static string FieldsFromEnum2(GuildFields flagsEnum)
        {
            int flagsValue = Convert.ToInt32(flagsEnum);

            var values = Enum.GetValues(flagsEnum.GetType()).Cast<int>().Where(x => (flagsValue & x) == x)
                    .Except(new[] { 0x0, 0x3, 0x7FFFFFFF }).Select(x => Enum.GetName(flagsEnum.GetType(), x).ToString()).ToArray();

            return string.Join(",", values).ToLowerInvariant();
        }

        public RealmStatus GetRealmStatus(Locale? locale = null, params string[] realms)
        {
            if (realms.Length != 0)
            {
                Dictionary<string, string> parameters = new Dictionary<string, string> { { "realm", string.Join(",", realms) } };
                return Get<RealmStatus>("realm/status", parameters, locale);
            }
            else
            {
                return Get<RealmStatus>("realm/status", null, locale);
            }
        }

        public RacesData GetRaces(Locale? locale = null)
        {
            return Get<RacesData>("data/character/races", null, locale);
        }

        public GuildRewardsData GetGuildRewards(Locale? locale = null)
        {
            return Get<GuildRewardsData>("data/guild/rewards", null, locale);
        }

        public GuildPerksData GetGuildPerks(Locale? locale = null)
        {
            return Get<GuildPerksData>("data/guild/perks");
        }

        public ClassesData GetClasses(Locale? locale = null)
        {
            return Get<ClassesData>("data/character/classes");
        }

        public RecipeData GetRecipe(int id, Locale? locale = null)
        {
            return Get<RecipeData>(string.Format("recipe/{0}", id), null, locale);
        }

        public QuestData GetQuest(int id, Locale? locale = null)
        {
            return Get<QuestData>(string.Format("quest/{0}", id), null, locale);
        }

        public Battlegroups GetBattlegroups(Locale? locale = null)
        {
            return Get<Battlegroups>("data/battlegroups/", null, locale);
        }
    }
}
