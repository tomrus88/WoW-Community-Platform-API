using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ArenaLadder
    {
        #pragma warning disable 0649
        [DataMember(Name = "arenateam")]
        public ArenaTeam[] ArenaTeam { get; private set; }
        #pragma warning restore 0649
    }
}
