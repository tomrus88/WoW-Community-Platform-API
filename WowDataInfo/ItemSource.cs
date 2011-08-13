using System.Runtime.Serialization;

namespace WowDataInfo
{
    [DataContract]
    public class ItemSource
    {
        [DataMember(Name = "sourceId")]
        public int SourceId { get; private set; }
        [DataMember(Name = "sourceType")]
        public string SourceType { get; private set; }
    }
}
