using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ArenaLadder : IEnumerable<ArenaTeam>
    {
        #pragma warning disable 0649
        [DataMember(Name = "arenateam")]
        public List<ArenaTeam> ArenaTeam { get; private set; }
        #pragma warning restore 0649

        public ArenaTeam this[int index]
        {
            get
            {
                return ArenaTeam[index];
            }
        }

        public IEnumerator<ArenaTeam> GetEnumerator()
        {
            return ArenaTeam.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
