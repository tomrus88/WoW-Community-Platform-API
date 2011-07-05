using System.Runtime.Serialization;

namespace WowGuildInfo
{
    [DataContract]
    public class Member
    {
        [DataMember(Name="character")]
        public Character Character;
        [DataMember(Name="rank")]
        public int Rank;
    }
}
