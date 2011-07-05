using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Guild
    {
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "realm")]
        public string Realm;
        [DataMember(Name = "level")]
        public int Level;
        [DataMember(Name = "members")]
        public int Members;
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints;
        [DataMember(Name = "emblem")]
        public Emblem Emblem;
    }

    [DataContract]
    public class Emblem
    {
        [DataMember(Name = "icon")]
        public int Icon;
        [DataMember(Name = "iconColor")]
        public string IconColor;
        [DataMember(Name = "border")]
        public int Border;
        [DataMember(Name = "borderColor")]
        public string BorderColor;
        [DataMember(Name = "backgroundColor")]
        public string BackgroundColor;
    }
}
