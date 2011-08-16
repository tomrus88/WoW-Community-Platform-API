using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Achievements
    {
        [DataMember(Name = "achievementsCompleted")]
        public int[] AchievementsCompleted { get; private set; }
        [DataMember(Name = "achievementsCompletedTimestamp")]
        public double[] AchievementsCompletedTimestamp { get; private set; }
        [DataMember(Name = "criteria")]
        public int[] Criteria { get; private set; }
        [DataMember(Name = "criteriaQuantity")]
        public long[] CriteriaQuantity { get; private set; }
        [DataMember(Name = "criteriaTimestamp")]
        public double[] CriteriaTimestamp { get; private set; }
        [DataMember(Name = "criteriaCreated")]
        public double[] CriteriaCreated { get; private set; }
    }
}
