using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Battlegroups
    {
        #pragma warning disable 0649
        [DataMember(Name = "battlegroups")]
        public Battlegroup[] BGs { get; private set; }
        #pragma warning disable 0649
    }

    [DataContract]
    public class Battlegroup
    {
        #pragma warning disable 0649
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "slug")]
        public string Slug { get; private set; }
        #pragma warning disable 0649
    }
}
