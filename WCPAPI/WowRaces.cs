using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class WowRaces
    {
        #pragma warning disable 0649
        [DataMember(Name = "races")]
        public Race[] Races;
        #pragma warning restore 0649
    }

    [DataContract]
    public class Race
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "mask")]
        public int Mask;
        [DataMember(Name = "side")]
        public string Side;
        [DataMember(Name = "name")]
        public string Name;
    }
}
