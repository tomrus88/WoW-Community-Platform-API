using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class GuildRewards
    {
        #pragma warning disable 0649
        [DataMember(Name = "rewards")]
        public GuildReward[] Rewards;
        #pragma warning restore 0649
    }

    [DataContract]
    public class GuildReward
    {
        //[DataMember(Name = "id")]
        //public int Id;
        //[DataMember(Name = "mask")]
        //public int Mask;
        //[DataMember(Name = "powerType")]
        //public string PowerType;
        //[DataMember(Name = "name")]
        //public string Name;
    }
}
