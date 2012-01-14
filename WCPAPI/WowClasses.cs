using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class WowClasses
    {
        #pragma warning disable 0649
        [DataMember(Name = "classes")]
        public Class[] Classes;
        #pragma warning restore 0649
    }

    [DataContract]
    public class Class
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "mask")]
        public int Mask;
        [DataMember(Name = "powerType")]
        public string PowerType;
        [DataMember(Name = "name")]
        public string Name;
    }
}
