using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ClassesData
    {
        #pragma warning disable 0649
        [DataMember(Name = "classes")]
        public Class[] Classes { get; private set; }
        #pragma warning restore 0649
    }

    [DataContract]
    public class Class
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "mask")]
        public int Mask { get; private set; }
        [DataMember(Name = "powerType")]
        public string PowerType { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
    }
}
