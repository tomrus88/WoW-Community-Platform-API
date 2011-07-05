using System;
using System.Runtime.Serialization;

namespace WCPAPI
{
    public enum RealmType
    {
        PvP,
        PvE,
        RP,
        RPPvP
    }

    public enum RealmPopulation
    {
        Low,
        Medium,
        High,
        Full
    }

    [DataContract]
    public class Realm
    {
        #pragma warning disable 0649
        [DataMember(Name = "type")]
        private string m_type;
        [DataMember(Name = "population")]
        private string m_population;
        [DataMember(Name = "queue")]
        public bool Queue;
        [DataMember(Name = "status")]
        public bool Status;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "slug")]
        public string Slug;
        #pragma warning restore 0649

        public RealmType Type
        {
            get
            {
                return (RealmType)Enum.Parse(typeof(RealmType), m_type, true);
            }
        }

        public RealmPopulation Population
        {
            get
            {
                return (RealmPopulation)Enum.Parse(typeof(RealmPopulation), m_population, true);
            }
        }

        public string[] ToStringArray()
        {
            return new string[]
            {
                Name,
                Slug,
                Type.ToString(),
                Population.ToString(),
                Queue.ToString(),
                Status.ToString()
            };
        }
    }
}
