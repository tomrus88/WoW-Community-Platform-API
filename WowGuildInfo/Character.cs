using System.Runtime.Serialization;
using WCPAPI;

namespace WowGuildInfo
{
    [DataContract]
    public class Character
    {
        #pragma warning disable 0649
        [DataMember(Name="name")]
        public string Name { get; private set; }
        [DataMember(Name = "realm")]
        public string Realm { get; private set; }
        [DataMember(Name = "class")]
        public WowClass Class { get; private set; }
        [DataMember(Name = "race")]
        public WowRace Race { get; private set; }
        [DataMember(Name = "gender")]
        public WowGender Gender { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints { get; private set; }
        [DataMember(Name = "thumbnail")]
        public string Thumbnail { get; private set; }
        #pragma warning restore 0649
    }
}
