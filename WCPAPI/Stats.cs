using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Stats
    {
        [DataMember(Name = "health")]
        public int Health { get; private set; }
        [DataMember(Name = "powerType")]
        public string PowerType { get; private set; }
        [DataMember(Name = "power")]
        public int Power { get; private set; }
        [DataMember(Name = "str")]
        public int Strength { get; private set; }
        [DataMember(Name = "agi")]
        public int Agility { get; private set; }
        [DataMember(Name = "sta")]
        public int Stamina { get; private set; }
        [DataMember(Name="int")]
        public int Intellect { get; private set; }
        [DataMember(Name = "spr")]
        public int Spirit { get; private set; }
        [DataMember(Name = "attackPower")]
        public int AttackPower { get; private set; }
        [DataMember(Name = "rangedAttackPower")]
        public int RangedAttackPower { get; private set; }
        [DataMember(Name = "mastery")]
        public float Mastery { get; private set; }
        [DataMember(Name = "masteryRating")]
        public int MasteryRating { get; private set; }
        [DataMember(Name = "crit")]
        public float Crit { get; private set; }
        [DataMember(Name = "critRating")]
        public int CritRating { get; private set; }
        [DataMember(Name = "hitPercent")]
        public float HitPercent { get; private set; }
        [DataMember(Name = "hitRating")]
        public int HitRating { get; private set; }
        [DataMember(Name = "hasteRating")]
        public int HasteRating { get; private set; }
        [DataMember(Name = "expertiseRating")]
        public int ExpertiseRating { get; private set; }
        [DataMember(Name = "spellPower")]
        public int SpellPower { get; private set; }
        [DataMember(Name = "spellPen")]
        public int SpellPen { get; private set; }
        [DataMember(Name = "spellCrit")]
        public float SpellCrit { get; private set; }
        [DataMember(Name = "spellCritRating")]
        public int SpellCritRating { get; private set; }
        [DataMember(Name = "spellHitPercent")]
        public float SpellHitPercent { get; private set; }
        [DataMember(Name = "spellHitRating")]
        public int SpellHitRating { get; private set; }
        [DataMember(Name = "mana5")]
        public float Mana5 { get; private set; }
        [DataMember(Name = "mana5Combat")]
        public float Mana5Combat { get; private set; }
        [DataMember(Name = "armor")]
        public int Armor { get; private set; }
        [DataMember(Name = "dodge")]
        public float Dodge { get; private set; }
        [DataMember(Name = "dodgeRating")]
        public int DodgeRating { get; private set; }
        [DataMember(Name = "parry")]
        public float Parry { get; private set; }
        [DataMember(Name = "parryRating")]
        public int ParryRating { get; private set; }
        [DataMember(Name = "block")]
        public float Block { get; private set; }
        [DataMember(Name = "blockRating")]
        public int BlockRating { get; private set; }
        [DataMember(Name = "resil")]
        public int Resilience { get; private set; }
        [DataMember(Name = "mainHandDmgMin")]
        public float MainHandDmgMin { get; private set; }
        [DataMember(Name = "mainHandDmgMax")]
        public float MainHandDmgMax { get; private set; }
        [DataMember(Name = "mainHandSpeed")]
        public float MainHandSpeed { get; private set; }
        [DataMember(Name = "mainHandDps")]
        public float MainHandDps { get; private set; }
        [DataMember(Name = "mainHandExpertise")]
        public int MainHandExpertise { get; private set; }
        [DataMember(Name = "offHandDmgMin")]
        public float OffHandDmgMin { get; private set; }
        [DataMember(Name = "offHandDmgMax")]
        public float OffHandDmgMax { get; private set; }
        [DataMember(Name = "offHandSpeed")]
        public float OffHandSpeed { get; private set; }
        [DataMember(Name = "offHandDps")]
        public float OffHandDps { get; private set; }
        [DataMember(Name = "offHandExpertise")]
        public int OffHandExpertise { get; private set; }
        [DataMember(Name = "rangedDmgMin")]
        public float RangedDmgMin { get; private set; }
        [DataMember(Name = "rangedDmgMax")]
        public float RangedDmgMax { get; private set; }
        [DataMember(Name = "rangedSpeed")]
        public float RangedSpeed { get; private set; }
        [DataMember(Name = "rangedDps")]
        public float RangedDps { get; private set; }
        [DataMember(Name = "rangedCrit")]
        public float RangedCrit { get; private set; }
        [DataMember(Name = "rangedCritRating")]
        public int RangedCritRating { get; private set; }
        [DataMember(Name = "rangedHitPercent")]
        public float RangedHitPercent { get; private set; }
        [DataMember(Name = "rangedHitRating")]
        public int RangedHitRating { get; private set; }
    }
}
