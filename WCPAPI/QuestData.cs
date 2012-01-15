using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class QuestData
    {
        #pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "title")]
        public string Title { get; private set; }
        [DataMember(Name = "reqLevel")]
        public int ReqLevel { get; private set; }
        [DataMember(Name = "suggestedPartyMembers")]
        public int SuggestedPartyMembers { get; private set; }
        [DataMember(Name = "category")]
        public string Category { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        #pragma warning restore 0649
    }
}
