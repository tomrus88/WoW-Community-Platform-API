using System;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterProgression
    {
        [DataMember(Name = "raids")]
        public Raid[] Raids { get; private set; }
    }

    [DataContract]
    public class Raid
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "normal")]
        public int Normal { get; private set; }
        [DataMember(Name = "heroic")]
        public int Heroic { get; private set; }
        [DataMember(Name = "id")]
        public int Id { get; private set; }
        [DataMember(Name = "bosses")]
        public Boss[] Bosses { get; private set; }

        public override string ToString()
        {
            return String.Format("Id {0}, Name {1}", Id, Name);
        }
    }

    [DataContract]
    public class Boss
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "lfrKills")]
        public int LfrKills { get; private set; }
        [DataMember(Name = "lfrTimestamp")]
        public long LfrTimestamp;
        [DataMember(Name = "normalKills")]
        public int NormalKills { get; private set; }
        [DataMember(Name = "normalTimestamp")]
        public long NormalTimestamp;
        [DataMember(Name = "heroicKills")]
        public int HeroicKills { get; private set; }
        [DataMember(Name = "heroicTimestamp")]
        public long HeroicTimestamp;
        [DataMember(Name = "id")]
        public int Id { get; private set; }
    }
}
