using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLQueen
{

    public class wrapper
    {
        public Summoner summoner { get; set; }
    }

    public class Summoner
    {
        internal Summoner summoner;

        public int profileIconID { get; set; }
        public string name { get; set; }
        public int summonerLevel { get; set; }
        public long revisionDate { get; set; }
        public long id { get; set; }
        public long accountID { get; set; }

        public static implicit operator Summoner(wrapper v)
        {
            throw new NotImplementedException();
        }
    }
}
