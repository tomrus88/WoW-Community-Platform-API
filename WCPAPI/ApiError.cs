using System;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [Serializable]
    [DataContract]
    public class ApiError
    {
        public ApiError(string status, string reason)
        {
            Status = status;
            Reason = reason;
        }

        // fields for failed response
        [DataMember(Name = "status")]
        public string Status { get; private set; }
        [DataMember(Name = "reason")]
        public string Reason { get; private set; }
    }
}
