namespace LoLQueen
{
    public class Quick
    {
        public int Won { get; set; }
    }

    public class Comp
    {
        public int Won { get; set; }
        public int Lost { get; set; }
        public int Draw { get; set; }
        public int Played { get; set; }
    }

    public class Games
    {
        public Quick Quickplay { get; set; }
        public Comp Competitive { get; set; }
    }

    public class Playtime
    {
        public string Quickplay { get; set; }
        public string Competitive { get; set; }
    }

    public class Comp2
    {
        public int Rank { get; set; }
        public string RankImg { get; set; }
    }

    public class Root
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public string Portrait { get; set; }
        public Games Games { get; set; }
        public Playtime Playtime { get; set; }
        public Comp2 Competitive { get; set; }
        public string LevelFrame { get; set; }
        public string Star { get; set; }
    }
}