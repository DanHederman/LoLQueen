using System.Collections.Generic;

namespace LoLQueen
{
    public class MatchList
    {
        public List<Match> Matches;
        public int TotalGames;
        public int StartIndex;
        public int EndIndex;
    }

    public class Match
    {
        public string Lane { get; set; }
        public long GameId { get; set; }
        public int Champion { get; set; }
        public string PlatformId { get; set; }
        public int Season { get; set; }
        public int Queue { get; set; }
        public string Role { get; set; }
        public long Timestamp { get; set; }
    }
}
