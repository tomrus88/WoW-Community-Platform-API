using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterItems
    {
        #pragma warning disable 0649
        [DataMember(Name = "averageItemLevel")]
        public int AverageItemLevel { get; private set; }
        [DataMember(Name = "averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; private set; }
        [DataMember(Name = "head")]
        public CharacterItem Head { get; private set; }
        [DataMember(Name = "neck")]
        public CharacterItem Neck { get; private set; }
        [DataMember(Name = "shoulder")]
        public CharacterItem Shoulder { get; private set; }
        [DataMember(Name = "back")]
        public CharacterItem Back { get; private set; }
        [DataMember(Name = "chest")]
        public CharacterItem Chest { get; private set; }
        [DataMember(Name = "shirt")]
        public CharacterItem Shirt { get; private set; }
        [DataMember(Name = "tabard")]
        public CharacterItem Tabard { get; private set; }
        [DataMember(Name = "wrist")]
        public CharacterItem Wrist { get; private set; }
        [DataMember(Name = "hands")]
        public CharacterItem Hands { get; private set; }
        [DataMember(Name = "waist")]
        public CharacterItem Waist { get; private set; }
        [DataMember(Name = "legs")]
        public CharacterItem Legs { get; private set; }
        [DataMember(Name = "feet")]
        public CharacterItem Feet { get; private set; }
        [DataMember(Name = "finger1")]
        public CharacterItem Finger1 { get; private set; }
        [DataMember(Name = "finger2")]
        public CharacterItem Finger2 { get; private set; }
        [DataMember(Name = "trinket1")]
        public CharacterItem Trinket1 { get; private set; }
        [DataMember(Name = "trinket2")]
        public CharacterItem Trinket2 { get; private set; }
        [DataMember(Name = "mainHand")]
        public CharacterItem MainHand { get; private set; }
        [DataMember(Name = "ranged")]
        public CharacterItem Ranged { get; private set; }
        #pragma warning restore 0649
    }
}
