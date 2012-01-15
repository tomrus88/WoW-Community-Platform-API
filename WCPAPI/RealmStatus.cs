using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class RealmStatus
    {
        [DataMember(Name = "realms")]
        public Realm[] Realms { get; private set; }
    }
}
