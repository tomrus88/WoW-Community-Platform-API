using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Items
    {
        #pragma warning disable 0649
        [DataMember(Name = "averageItemLevel")]
        public int AverageItemLevel;
        [DataMember(Name = "averageItemLevelEquipped")]
        public int AverageItemLevelEquipped;
        [DataMember(Name = "head")]
        public Item Head;
        [DataMember(Name = "neck")]
        public Item Neck;
        [DataMember(Name = "shoulder")]
        public Item Shoulder;
        [DataMember(Name = "back")]
        public Item Back;
        [DataMember(Name = "chest")]
        public Item Chest;
        [DataMember(Name = "shirt")]
        public Item Shirt;
        [DataMember(Name = "tabard")]
        public Item Tabard;
        [DataMember(Name = "wrist")]
        public Item Wrist;
        [DataMember(Name = "hands")]
        public Item Hands;
        [DataMember(Name = "waist")]
        public Item Waist;
        [DataMember(Name = "legs")]
        public Item Legs;
        [DataMember(Name = "feet")]
        public Item Feet;
        [DataMember(Name = "finger1")]
        public Item Finger1;
        [DataMember(Name = "finger2")]
        public Item Finger2;
        [DataMember(Name = "trinket1")]
        public Item Trinket1;
        [DataMember(Name = "trinket2")]
        public Item Trinket2;
        [DataMember(Name = "mainHand")]
        public Item MainHand;
        [DataMember(Name = "ranged")]
        public Item Ranged;
        #pragma warning restore 0649
    }
}
