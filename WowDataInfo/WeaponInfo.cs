using System.Runtime.Serialization;

namespace WowDataInfo
{
    [DataContract]
    public class WeaponInfo
    {
        [DataMember(Name = "damage")]
        public Damage[] Damage { get; private set; }
        [DataMember(Name = "weaponSpeed")]
        public float WeaponSpeed { get; private set; }
        [DataMember(Name = "dps")]
        public float Dps { get; private set; }
    }

    [DataContract]
    public class Damage
    {
        [DataMember(Name = "minDamage")]
        public int MinDamage { get; private set; }
        [DataMember(Name = "maxDamage")]
        public int MaxDamage { get; private set; }
    }
}
