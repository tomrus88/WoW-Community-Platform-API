using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class RecipeData
    {
        #pragma warning disable 0649
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "profession")]
        public string Profession { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        #pragma warning restore 0649
    }
}
