using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ArenaTeamMember
    {
        #pragma warning disable 0649
        [DataMember(Name = "character")]
        public MetaCharacter Character { get; private set; }
        [DataMember(Name = "rank")]
        public int Rank { get; private set; }
        [DataMember(Name = "gamesPlayed")]
        public int GamesPlayed { get; private set; }
        [DataMember(Name = "gamesWon")]
        public int GamesWon { get; private set; }
        [DataMember(Name = "gamesLost")]
        public int GamesLost { get; private set; }
        [DataMember(Name = "sessionGamesPlayed")]
        public int SessionGamesPlayed { get; private set; }
        [DataMember(Name = "sessionGamesWon")]
        public int SessionGamesWon { get; private set; }
        [DataMember(Name = "sessionGamesLost")]
        public int SessionGamesLost { get; private set; }
        [DataMember(Name = "personalRating")]
        public int PersonalRating { get; private set; }
        #pragma warning restore 0649
    }
}
