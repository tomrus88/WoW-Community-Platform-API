using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Item
    {
        #pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "disenchantingSkillRank")]
        public int DisenchantingSkillRank { get; private set; }
        [DataMember(Name = "description")]
        public string Description { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        [DataMember(Name = "stackable")]
        public int Stackable { get; private set; }
        [DataMember(Name = "allowableClasses")]
        public int[] AllowableClasses { get; private set; }
        [DataMember(Name = "itemBind")]
        public int ItemBind { get; private set; }
        [DataMember(Name = "bonusStats")]
        public BonusStat[] BonusStats { get; private set; }
        [DataMember(Name = "itemSpells")]
        public ItemSpell[] ItemSpells { get; private set; }
        [DataMember(Name = "buyPrice")]
        public int BuyPrice { get; private set; }
        [DataMember(Name = "itemClass")]
        public int ItemClass { get; private set; }
        [DataMember(Name = "itemSubClass")]
        public int ItemSubClass { get; private set; }
        [DataMember(Name = "containerSlots")]
        public int ContainerSlots { get; private set; }
        [DataMember(Name = "weaponInfo")]
        public WeaponInfo WeaponInfo { get; private set; }
        [DataMember(Name = "inventoryType")]
        public int InventoryType { get; private set; }
        [DataMember(Name = "equippable")]
        public bool Equippable { get; private set; }
        [DataMember(Name = "itemLevel")]
        public int ItemLevel { get; private set; }
        //[DataMember(Name = "itemSet")]
        //public int ItemSet { get; private set; }
        [DataMember(Name = "maxCount")]
        public int MaxCount { get; private set; }
        [DataMember(Name = "maxDurability")]
        public int MaxDurability { get; private set; }
        [DataMember(Name = "minFactionId")]
        public int MinFactionId { get; private set; }
        [DataMember(Name = "minReputation")]
        public int MinReputation { get; private set; }
        [DataMember(Name = "quality")]
        public int Quality { get; private set; }
        [DataMember(Name = "sellPrice")]
        public int SellPrice { get; private set; }
        [DataMember(Name = "requiredLevel")]
        public int RequiredLevel { get; private set; }
        [DataMember(Name = "requiredSkill")]
        public int RequiredSkill { get; private set; }
        [DataMember(Name = "requiredSkillRank")]
        public int RequiredSkillRank { get; private set; }
        [DataMember(Name = "socketInfo")]
        public SocketInfo SocketInfo { get; private set; }
        [DataMember(Name = "itemSource")]
        public ItemSource ItemSource { get; private set; }
        [DataMember(Name = "baseArmor")]
        public int BaseArmor { get; private set; }
        [DataMember(Name = "hasSockets")]
        public bool HasSockets { get; private set; }
        [DataMember(Name = "isAuctionable")]
        public bool IsAuctionable { get; private set; }
        [DataMember(Name = "armor")]
        public int Armor { get; private set; }
        [DataMember(Name = "displayInfoId")]
        public int DisplayInfoId { get; private set; }
        [DataMember(Name = "nameDescription")]
        public string NameDescription { get; private set; }
        [DataMember(Name = "nameDescriptionColor")]
        public string NameDescriptionColor { get; private set; }
        [DataMember(Name = "upgradable")]
        public bool Upgradable { get; private set; }
        [DataMember(Name = "heroicTooltip")]
        public bool HeroicTooltip { get; private set; }
        [DataMember(Name = "context")]
        public string Context { get; private set; }
#pragma warning disable 0649
    }
}
