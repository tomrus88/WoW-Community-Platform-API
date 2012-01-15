using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class GuildPerksData
    {
        #pragma warning disable 0649
        [DataMember(Name = "perks")]
        public GuildPerk[] Perks { get; private set; }
        #pragma warning restore 0649
    }

    [DataContract]
    public class GuildPerk
    {
        [DataMember(Name = "guildLevel")]
        public int GuildLevel { get; private set; }
        [DataMember(Name = "spell")]
        public SpellInfo Spell { get; private set; }
    }
}
