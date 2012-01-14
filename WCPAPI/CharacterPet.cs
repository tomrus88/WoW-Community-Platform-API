using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterPet
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "creature")]
        public int Creature { get; private set; }
        [DataMember(Name = "slot")]
        public int Slot { get; private set; }
        [DataMember(Name = "selected")]
        public bool Selected { get; private set; }
    }
}
