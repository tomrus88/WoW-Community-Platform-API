using System.Runtime.Serialization;
using WCPAPI;

namespace WowGuildInfo
{
    [DataContract]
    public class Character
    {
#pragma warning disable 0649
        [DataMember]
        public string name { get; private set; }
        [DataMember]
        public string realm { get; private set; }
        [DataMember]
        public WowClass @class { get; private set; }
        [DataMember]
        public WowRace race { get; private set; }
        [DataMember]
        public WowGender gender { get; private set; }
        [DataMember]
        public int level { get; private set; }
        [DataMember]
        public int achievementPoints { get; private set; }
        [DataMember]
        public string thumbnail { get; private set; }
#pragma warning restore 0649
    }
}
