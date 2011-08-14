using System.Runtime.Serialization;

namespace WowDataInfo
{
    [DataContract]
    public class BonusStat
    {
        [DataMember(Name = "stat")]
        public int Stat { get; private set; }
        [DataMember(Name = "amount")]
        public int Amount { get; private set; }
        [DataMember(Name = "reforged")]
        public bool Reforged { get; private set; }
    }
}
