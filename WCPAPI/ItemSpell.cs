using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ItemSpell
    {
        [DataMember(Name = "spellId")]
        public int SpellId { get; private set; }
        [DataMember(Name = "spell")]
        public SpellInfo Spell { get; private set; }
        [DataMember(Name = "nCharges")]
        public int NumCharges { get; private set; }
        [DataMember(Name = "consumable")]
        public bool Consumable { get; private set; }
        [DataMember(Name = "categoryId")]
        public int CategoryId { get; private set; }
    }
}
