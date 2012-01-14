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
        public Emblem Emblem { get; private set; }
    }

    [DataContract]
    public class Emblem
    {
        [DataMember(Name = "icon")]
        public int Icon { get; private set; }
        [DataMember(Name = "iconColor")]
        public string IconColor { get; private set; }
        [DataMember(Name = "border")]
        public int Border { get; private set; }
        [DataMember(Name = "borderColor")]
        public string BorderColor { get; private set; }
        [DataMember(Name = "backgroundColor")]
        public string BackgroundColor { get; private set; }
    }
}
