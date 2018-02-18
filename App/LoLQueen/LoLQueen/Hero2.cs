namespace LoLQueen
/*
 * This second structure is also used to
 * get data from a second smaller json 
 * file that contains important indormation
 * that the large json file simply did not 
 * contain 
 */
{
    /// <summary>
    /// Structure to hold quickplay game data
    /// </summary>
    public class Quick
    {
        public int Won { get; set; }
    }
    /// <summary>
    /// Structure to hold competitive game data
    /// </summary>
    public class Comp
    {
        public int Won { get; set; }
        public object Lost { get; set; }
        public int Draw { get; set; }
        public int Played { get; set; }
    }
    /// <summary>
    /// Base structure to split game type data
    /// </summary>
    public class Games
    {
        public Quick Quickplay { get; set; }
        public Comp Competitive { get; set; }
    }
    /// <summary>
    /// Structure to split game time
    /// </summary>
    public class Playtime
    {
        public string Quick { get; set; }
        public string Comp { get; set; }
    }
    /// <summary>
    /// Structure to hold what rank the user is 
    /// </summary>
    public class Comp2
    {
        public int rank { get; set; }
        public string Rank_img { get; set; }
    }

    /// <summary>
    /// Structure base to hold the heros data
    /// </summary>
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