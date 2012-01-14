using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class TooltipParams
    {
        [DataMember(Name = "gem0")]
        public int Gem0 { get; private set; }
        [DataMember(Name = "gem1")]
        public int Gem1 { get; private set; }
        [DataMember(Name = "enchant")]
        public int Enchant { get; private set; }
        [DataMember(Name = "set")]
        public int[] Set { get; private set; }
        [DataMember(Name = "reforge")]
        public int Reforge { get; private set; }
        [DataMember(Name = "suffix")]
        public int Suffix { get; private set; }
        [DataMember(Name = "seed")]
        public int Seed { get; private set; }
        [DataMember(Name = "extraSocket")]
        public bool ExtraSocket { get; private set; }
    }
}
