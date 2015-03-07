using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ItemSet
    {
#pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "setBonuses")]
        public ItemSetBonus[] SetBonuses { get; private set; }
        [DataMember(Name = "items")]
        public int[] Items { get; private set; }
#pragma warning restore 0649
    }

    [DataContract]
    public class ItemSetBonus
    {
#pragma warning disable 0649
        [DataMember(Name = "description")]
        public string Description { get; private set; }
        [DataMember(Name = "threshold")]
        public int Threshold { get; private set; }
#pragma warning restore 0649
    }
}
