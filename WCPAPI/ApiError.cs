using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ApiError
    {
        // fields for failed response
        [DataMember(Name = "status")]
        public string Status { get; private set; }
        [DataMember(Name = "reason")]
        public string Reason { get; private set; }
    }
}
