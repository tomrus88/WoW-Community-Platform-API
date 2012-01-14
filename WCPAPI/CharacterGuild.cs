using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterGuild
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "realm")]
        public string Realm { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        [DataMember(Name = "members")]
        public int Members { get; private set; }
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints { get; private set; }
        [DataMember(Name = "emblem")]
        public GuildEmblem Emblem { get; private set; }
    }
}
