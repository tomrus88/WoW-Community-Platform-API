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
        [DataMember(Name = "lfr")]
        public int Lfr { get; private set; }
        [DataMember(Name = "normal")]
        public int Normal { get; private set; }
        [DataMember(Name = "heroic")]
        public int Heroic { get; private set; }
        [DataMember(Name = "mythic")]
        public int Mythic { get; private set; }
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
        public long LfrTimestamp { get; private set; }
        [DataMember(Name = "normalKills")]
        public int NormalKills { get; private set; }
        [DataMember(Name = "normalTimestamp")]
        public long NormalTimestamp { get; private set; }
        [DataMember(Name = "heroicKills")]
        public int HeroicKills { get; private set; }
        [DataMember(Name = "heroicTimestamp")]
        public long HeroicTimestamp { get; private set; }
        [DataMember(Name = "mythicKills")]
        public int MythicKills { get; private set; }
        [DataMember(Name = "mythicTimestamp")]
        public long MythicTimestamp { get; private set; }
        [DataMember(Name = "id")]
        public int Id { get; private set; }
    }
}
