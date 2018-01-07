using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLQueen
{
    public class Summoner
    {
        private int ProfileIconId { get; set; }
        public string Name { get; set; }
        public int SummonerLevel { get; set; }
        public long RevisionDate { get; set; }
        public long Id { get; set; }
        public long AccountId { get; set; }
    }

}