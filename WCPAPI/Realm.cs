using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Realm
    {
        #pragma warning disable 0649
        [DataMember(Name = "type")]
        public string type;
        [DataMember(Name = "population")]
        public string population;
        [DataMember(Name = "queue")]
        public bool queue;
        [DataMember(Name = "status")]
        public bool status;
        [DataMember(Name = "name")]
        public string name;
        [DataMember(Name = "slug")]
        public string slug;
        #pragma warning restore 0649

        public string[] ToStringArray()
        {
            return new string[]
            {
                name,
                slug,
                type,
                population,
                queue.ToString(),
                status.ToString()
            };
        }
    }
}
