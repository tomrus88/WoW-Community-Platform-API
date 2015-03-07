using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class WeaponInfo
    {
        [DataMember(Name = "damage")]
        public Damage Damage { get; private set; }
        [DataMember(Name = "weaponSpeed")]
        public float WeaponSpeed { get; private set; }
        [DataMember(Name = "dps")]
        public float Dps { get; private set; }
    }

    [DataContract]
    public class Damage
    {
        [DataMember(Name = "exactMax")]
        public float ExactMax { get; private set; }
        [DataMember(Name = "exactMin")]
        public float ExactMin { get; private set; }
        [DataMember(Name = "max")]
        public int Min { get; private set; }
        [DataMember(Name = "min")]
        public int Max { get; private set; }
    }
}
