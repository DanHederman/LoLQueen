using System.Collections.Generic;
/*
 * This class contains a number of different structures 
 * that have the information from the json read into 
 * thses structures to then be accessed aqnd displayed 
 * to the user
 */
namespace LoLQueen
{
    /// <summary>
    /// Structure holds Hero details for quickplay
    /// </summary>
    public class Quickplay
    {
        public string Hero { get; set; }
        public string Played { get; set; }
        public string Img { get; set; }
    }
    /// <summary>
    /// Structure holds Hero details for competitive 
    /// </summary>
    public class Competitive
    {
        public string Hero { get; set; }
        public string Played { get; set; }
        public string Img { get; set; }
    }
    /// <summary>
    /// Strructure for top picked hero
    /// from each game type
    /// </summary>
    public class TopHeroes
    {
        public List<Quickplay> Quickplay { get; set; }
        public List<Competitive> Competitive { get; set; }
    }

    public class Quickplay2
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Competitive2
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
    /// <summary>
    /// Structure containing lists that will hold 
    /// the data for each of the game types combat stats
    /// </summary>
    public class Combat
    {
        public List<Quickplay2> Quickplay { get; set; }
        public List<Competitive2> Competitive { get; set; }
    }

    public class Quickplay3
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Competitive3
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
    /// <summary>
    /// Structure that contains lists to hold the 
    /// MatchAwards fro each hero in each game type
    /// </summary>
    public class MatchAwards
    {
        public List<Quickplay3> Quickplay { get; set; }
        public List<Competitive3> Competitive { get; set; }
    }

    public class Quickplay4
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Competitive4
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
    /// <summary>
    /// Structure that contains lists to hold 
    /// info on assists for each game type 
    /// </summary>

    public class Assists
    {
        public List<Quickplay4> Quickplay { get; set; }
        public List<Competitive4> Competitive { get; set; }
    }

    public class Quickplay5
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Competitive5
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Average
    {
        public List<Quickplay5> Quickplay { get; set; }
        public List<Competitive5> Competitive { get; set; }
    }

    public class Quickplay6
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Miscellaneous
    {
        public List<Quickplay6> Quickplay { get; set; }
        public List<object> Competitive { get; set; }
    }

    public class Quickplay7
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Competitive6
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Best
    {
        public List<Quickplay7> Quickplay { get; set; }
        public List<Competitive6> Competitive { get; set; }
    }
    /// <summary>
    /// Holds 2 values i.e. title = "Most elims in game"
    /// value = "68"
    /// </summary>
    public class Quickplay8
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class Competitive7
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
    /// <summary>
    /// Splits the different game types that 
    /// are held in the json file 
    /// </summary>
    public class Game
    {
        public List<Quickplay8> Quickplay { get; set; }
        public List<Competitive7> Competitive { get; set; }
    }
    /// <summary>
    /// Structure that is used to group all the 
    /// other structures 
    /// </summary>
    public class Stats
    {
        public TopHeroes TopHeroes { get; set; }
        public Combat Combat { get; set; }
        public MatchAwards MatchAwards { get; set; }
        public Assists Assists { get; set; }
        public Average Average { get; set; }
        public Miscellaneous Miscellaneous { get; set; }
        public Best Best { get; set; }
        public Game Game { get; set; }
    }
    /// <summary>
    /// Base structure to hold all game data 
    /// that is read in from the json
    /// </summary>
    public class RootObject
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public string Portrait { get; set; }
        public Stats Stats { get; set; }
    }
}