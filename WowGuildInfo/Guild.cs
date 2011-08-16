using System;
using System.Runtime.Serialization;
using WCPAPI;

namespace WowGuildInfo
{
    [DataContract]
    public class Guild
    {
        #pragma warning disable 0649
        [DataMember(Name = "lastModified")]
        private double m_lastModified;
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "realm")]
        public string Realm { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        [DataMember(Name = "side")]
        public int Side { get; private set; }
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints { get; private set; }
        [DataMember(Name = "achievements", IsRequired=false)]
        public Achievements Achievements { get; private set; }
        [DataMember(Name = "members", IsRequired = false)]
        public Member[] Members { get; private set; }
        #pragma warning restore 0649

        public DateTime LastModified
        {
            get
            {
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                return origin.AddSeconds(m_lastModified / 1000.0f);
            }
        }
    }
}
