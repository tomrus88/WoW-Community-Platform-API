using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterPvp
    {
        [DataMember(Name = "ratedBattlegrounds")]
        public RatedBattlegrounds RatedBattlegrounds { get; private set; }
        [DataMember(Name = "arenaTeams")]
        public ArenaTeam2[] ArenaTeams { get; private set; }
        [DataMember(Name = "totalHonorableKills")]
        public int TotalHonorableKills { get; private set; }
    }

    [DataContract]
    public class RatedBattlegrounds
    {
        [DataMember(Name = "personalRating")]
        public int PersonalRating { get; private set; }
        [DataMember(Name = "battlegrounds")]
        public Battleground[] Battlegrounds { get; private set; }
    }

    [DataContract]
    public class Battleground
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "played")]
        public int Played { get; private set; }
        [DataMember(Name = "won")]
        public int Won { get; private set; }
    }

    [DataContract]
    public class ArenaTeam2
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "personalRating")]
        public int PersonalRating { get; private set; }
        [DataMember(Name = "teamRating")]
        public int TeamRating { get; private set; }
        [DataMember(Name = "size")]
        public string Size { get; private set; }
    }
}
