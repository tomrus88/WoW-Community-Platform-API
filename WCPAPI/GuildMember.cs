using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class GuildMember
    {
        [DataMember(Name="character")]
        public GuildCharacter Character { get; private set; }
        [DataMember(Name="rank")]
        public int Rank { get; private set; }
    }
}
