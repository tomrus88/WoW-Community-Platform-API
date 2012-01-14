using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class SpellInfo
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "subtext")]
        public string SubText { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        [DataMember(Name = "description")]
        public string Description { get; private set; }
        [DataMember(Name = "range")]
        public string Range { get; private set; }
        [DataMember(Name = "castTime")]
        public string CastTime { get; private set; }
        [DataMember(Name = "cooldown")]
        public string Cooldown { get; private set; }
    }
}
