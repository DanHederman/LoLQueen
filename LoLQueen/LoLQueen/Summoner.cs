using System;
using LoLQueen;

namespace LoLQueen
{

    public class wrapper
    {
        public Summoner summoner { get; set; }
    }

    public class Summoner
    {
        internal Summoner summoner;

        public int ProfileIconId { get; set; }
        public string Name { get; set; }
        public int SummonerLevel { get; set; }
        public long RevisionDate { get; set; }
        public long Id { get; set; }
        public long AccountId { get; set; }

        public static implicit operator Summoner(wrapper v)
        {
            throw new NotImplementedException();
        }
    }

    public class MatchHistory
    {
        internal MatchHistory matches;

        public string Lane { get; set; }
        public long GameID { get; set; }
        public int Champion { get; set; }
        public string PlatformID { get; set; }
        public int Season { get; set; }
        public int Queue { get; set; }
        public string role { get; set; }
        public long Timestamp { get; set; }

        public static implicit operator MatchHistory(wrapper v)
        {
            throw new NotImplementedException();
        }
    }
}
