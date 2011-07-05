using System.Collections.Generic;
using System.Runtime.Serialization;
using WCPAPI;

namespace WowGuildInfo
{
    [DataContract]
    public class Guild
    {
        [DataMember(Name = "lastModified")]
        public double LastModified;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "realm")]
        public string Realm;
        [DataMember(Name = "level")]
        public int Level;
        [DataMember(Name = "side")]
        public int Side;
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints;
        [DataMember(Name = "achievements")]
        public Achievements Achievements;
        [DataMember(Name = "members")]
        public List<Member> Members;
    }
}
