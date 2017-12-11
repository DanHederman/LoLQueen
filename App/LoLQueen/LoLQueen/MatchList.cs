using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLQueen
{
    public class MatchList
    {
        public List<Match> matches;
        public int totalGames;
        public int startIndex;
        public int endIndex;
    }

    public class Match
    {
        public string Lane { get; set; }
        public long GameID { get; set; }
        public int Champion { get; set; }
        public string PlatformID { get; set; }
        public int Season { get; set; }
        public int Queue { get; set; }
        public string role { get; set; }
        public long Timestamp { get; set; }
    }
}
