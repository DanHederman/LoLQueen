using System.Collections.Generic;

namespace LoLQueen
{
    /// <summary>
    /// Base structure to get info based 
    /// on the match history
    /// </summary>
    public class MatchHist
    {
        public List<Match> Matches;
        public int TotalGames;
        public int StartIndex;
        public int EndIndex;
    
        public static MatchHist GetMatchHistory(string region, string accId)
        {
            var matchHistUrl = RiotUrl.GetMatchHistUrl(region, accId);
            var matchHist = JsonSettings.GetStats<MatchHist>(matchHistUrl);
            return matchHist;
        }
    }

    /// <summary>
    /// getters and setters to grab and display the information
    /// the user wants
    /// </summary>
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