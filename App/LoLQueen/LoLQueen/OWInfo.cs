namespace LoLQueen
{
    public class OWInfo
    {
        public class Quickplay
        {
            public int Won;
        }

        public class Competitive
        {
            public int Won;
            public int Lost;
            public int Draw;
            public int Played;
        }

        public class Games
        {
            public Quickplay Quickplay;
            public Competitive Competitive;
        }

        public class Playtime
        {
            public string Quickplay;
            public string Competitive;
        }

        public class Competitive2
        {
            public int Rank;
            public string RankImg;
        }

        public class MyJsonObject
        {
            public string Username;
            public int Level;
            public string Portrait;
            public Games Games;
            public Playtime Playtime;
            public Competitive2 Competitive;
            public string LevelFrame;
            public string Star;
        }
    }
}