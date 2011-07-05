using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Title
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "selected")]
        public bool Selected;
    }
}
