using System.Runtime.Serialization;

namespace WowDataInfo
{
    [DataContract]
    public class SpellInfo
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        [DataMember(Name = "description")]
        public string Description { get; private set; }
        [DataMember(Name = "castTime")]
        public string CastTime { get; private set; }
    }
}
