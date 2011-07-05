using System.Runtime.Serialization;

namespace WowGuildInfo
{
    [DataContract]
    public class Member
    {
        [DataMember(Name="character")]
        public Character Character { get; private set; }
        [DataMember(Name="rank")]
        public int Rank { get; private set; }
    }
}
