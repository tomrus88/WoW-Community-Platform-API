using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Achievements
    {
        [DataMember(Name = "achievementsCompleted")]
        public IList<int> AchievementsCompleted { get; private set; }
        [DataMember(Name = "achievementsCompletedTimestamp")]
        public IList<double> AchievementsCompletedTimestamp { get; private set; }
        [DataMember(Name = "criteria")]
        public IList<int> Criteria { get; private set; }
        [DataMember(Name = "criteriaQuantity")]
        public IList<long> CriteriaQuantity { get; private set; }
        [DataMember(Name = "criteriaTimestamp")]
        public IList<double> CriteriaTimestamp { get; private set; }
        [DataMember(Name = "criteriaCreated")]
        public IList<double> CriteriaCreated { get; private set; }
    }
}
