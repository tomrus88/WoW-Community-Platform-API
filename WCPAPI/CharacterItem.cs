using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterItem
    {
        #pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        [DataMember(Name = "quality")]
        public int Quality { get; private set; }
        [DataMember(Name = "tooltipParams")]
        public TooltipParams TooltipParams { get; private set; }
        #pragma warning disable 0649
    }
}
