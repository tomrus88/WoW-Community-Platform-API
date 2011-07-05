using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Achievements
    {
        [DataMember(Name = "achievementsCompleted")]
        public IList<int> AchievementsCompleted;
        [DataMember(Name = "achievementsCompletedTimestamp")]
        public IList<double> AchievementsCompletedTimestamp;
        [DataMember(Name = "criteria")]
        public IList<int> Criteria;
        [DataMember(Name = "criteriaQuantity")]
        public IList<long> CriteriaQuantity;
        [DataMember(Name = "criteriaTimestamp")]
        public IList<double> CriteriaTimestamp;
        [DataMember(Name = "criteriaCreated")]
        public IList<double> CriteriaCreated;
    }
}
