using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Professions
    {
        [DataMember(Name = "primary")]
        public IList<Profession> Primary { get; private set; }
        [DataMember(Name = "secondary")]
        public IList<Profession> Secondary { get; private set; }
    }

    [DataContract]
    public class Profession
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        [DataMember(Name = "rank")]
        public int Rank { get; private set; }
        [DataMember(Name = "max")]
        public int Max { get; private set; }
        [DataMember(Name = "recipes")]
        public IList<int> Recipes { get; private set; }
    }
}
