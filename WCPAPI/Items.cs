using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Items
    {
        #pragma warning disable 0649
        [DataMember(Name = "averageItemLevel")]
        public int AverageItemLevel { get; private set; }
        [DataMember(Name = "averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; private set; }
        [DataMember(Name = "head")]
        public Item Head { get; private set; }
        [DataMember(Name = "neck")]
        public Item Neck { get; private set; }
        [DataMember(Name = "shoulder")]
        public Item Shoulder { get; private set; }
        [DataMember(Name = "back")]
        public Item Back { get; private set; }
        [DataMember(Name = "chest")]
        public Item Chest { get; private set; }
        [DataMember(Name = "shirt")]
        public Item Shirt { get; private set; }
        [DataMember(Name = "tabard")]
        public Item Tabard { get; private set; }
        [DataMember(Name = "wrist")]
        public Item Wrist { get; private set; }
        [DataMember(Name = "hands")]
        public Item Hands { get; private set; }
        [DataMember(Name = "waist")]
        public Item Waist { get; private set; }
        [DataMember(Name = "legs")]
        public Item Legs { get; private set; }
        [DataMember(Name = "feet")]
        public Item Feet { get; private set; }
        [DataMember(Name = "finger1")]
        public Item Finger1 { get; private set; }
        [DataMember(Name = "finger2")]
        public Item Finger2 { get; private set; }
        [DataMember(Name = "trinket1")]
        public Item Trinket1 { get; private set; }
        [DataMember(Name = "trinket2")]
        public Item Trinket2 { get; private set; }
        [DataMember(Name = "mainHand")]
        public Item MainHand { get; private set; }
        [DataMember(Name = "ranged")]
        public Item Ranged { get; private set; }
        #pragma warning restore 0649
    }
}
