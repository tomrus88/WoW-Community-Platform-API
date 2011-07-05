using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Title
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "selected")]
        public bool Selected { get; private set; }
    }
}
