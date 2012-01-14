using System.Runtime.Serialization;

namespace WCPAPI
{
    public enum RepStanding
    {
        Hated = 0,
        Hostile = 1,
        Unfriendly = 2,
        Neutral = 3,
        Friendly = 4,
        Honored = 5,
        Revered = 6,
        Exalted = 7,
    }

    [DataContract]
    public class CharacterReputation
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "standing")]
        public RepStanding Standing { get; private set; }
        [DataMember(Name = "value")]
        public int Value { get; private set; }
        [DataMember(Name = "max")]
        public int Max { get; private set; }
    }
}
