using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Achievements
    {
        [DataMember(Name = "achievementsCompleted")]
        public List<int> AchievementsCompleted;
        [DataMember(Name = "achievementsCompletedTimestamp")]
        public List<double> AchievementsCompletedTimestamp;
        [DataMember(Name = "criteria")]
        public List<int> Criteria;
        [DataMember(Name = "criteriaQuantity")]
        public List<long> CriteriaQuantity;
        [DataMember(Name = "criteriaTimestamp")]
        public List<double> CriteriaTimestamp;
        [DataMember(Name = "criteriaCreated")]
        public List<double> CriteriaCreated;
    }
}
