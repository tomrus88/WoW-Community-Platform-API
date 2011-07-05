using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Pet
    {
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "creature")]
        public int Creature;
        [DataMember(Name = "slot")]
        public int Slot;
        [DataMember(Name = "selected")]
        public bool Selected;
    }
}
