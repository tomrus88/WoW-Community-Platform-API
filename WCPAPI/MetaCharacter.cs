using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class MetaCharacter
    {
        #pragma warning disable 0649
        [DataMember(Name="name")]
        public string Name { get; private set; }
        [DataMember(Name = "realm")]
        public string Realm { get; private set; }
        [DataMember(Name = "class")]
        public CharacterClass Class { get; private set; }
        [DataMember(Name = "race")]
        public CharacterRace Race { get; private set; }
        [DataMember(Name = "gender")]
        public CharacterGender Gender { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints { get; private set; }
        [DataMember(Name = "thumbnail")]
        public string Thumbnail { get; private set; }
        #pragma warning restore 0649
    }
}
