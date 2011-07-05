using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Item
    {
        #pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "icon")]
        public string Icon;
        [DataMember(Name = "quality")]
        public int Quality;
        [DataMember(Name = "tooltipParams")]
        public TooltipParams TooltipParams;
        #pragma warning disable 0649
    }

    [DataContract]
    public class TooltipParams
    {
        [DataMember(Name = "gem0")]
        public int Gem0;
        [DataMember(Name = "gem1")]
        public int Gem1;
        [DataMember(Name = "enchant")]
        public int Enchant;
        [DataMember(Name = "set")]
        public IList<int> Set;
        [DataMember(Name = "reforge")]
        public int Reforge;
        [DataMember(Name = "suffix")]
        public int Suffix;
        [DataMember(Name = "seed")]
        public int Seed;
        [DataMember(Name = "extraSocket")]
        public bool ExtraSocket;
    }
}
