using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class GuildRewardsData
    {
        #pragma warning disable 0649
        [DataMember(Name = "rewards")]
        public GuildReward[] Rewards { get; private set; }
        #pragma warning restore 0649
    }

    [DataContract]
    public class GuildReward
    {
        //[DataMember(Name = "id")]
        //public int Id { get; private set; }
        //[DataMember(Name = "mask")]
        //public int Mask { get; private set; }
        //[DataMember(Name = "powerType")]
        //public string PowerType { get; private set; }
        //[DataMember(Name = "name")]
        //public string Name { get; private set; }
    }
}
