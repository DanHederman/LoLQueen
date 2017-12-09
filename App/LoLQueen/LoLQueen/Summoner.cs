using System;

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
}
