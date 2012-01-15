using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class RacesData
    {
        #pragma warning disable 0649
        [DataMember(Name = "races")]
        public Race[] Races { get; private set; }
        #pragma warning restore 0649
    }

    [DataContract]
    public class Race
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "mask")]
        public int Mask { get; private set; }
        [DataMember(Name = "side")]
        public string Side { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
    }
}
