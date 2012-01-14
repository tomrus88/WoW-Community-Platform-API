using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class ArenaTeam
    {
        #pragma warning disable 0649
        [DataMember(Name = "realm")]
        public string Realm { get; private set; }
        [DataMember(Name = "ranking")]
        public int Ranking { get; private set; }
        [DataMember(Name = "rating")]
        public int Rating { get; private set; }
        [DataMember(Name = "teamsize")]
        public int TeamSize { get; private set; }
        [DataMember(Name = "created")]
        public string Created { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
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
        [DataMember(Name = "lastSessionRanking")]
        public int LastSessionRanking { get; private set; }
        [DataMember(Name = "side")]
        public string Side { get; private set; }
        [DataMember(Name = "currentWeekRanking")]
        public int CurrentWeekRanking { get; private set; }
        [DataMember(Name = "members")]
        public ArenaTeamMember[] Members { get; private set; }
        #pragma warning restore 0649
    }
}
