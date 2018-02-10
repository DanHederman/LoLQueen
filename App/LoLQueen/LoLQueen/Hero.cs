using System.Collections.Generic;
/*
 * This class contains a number of different structures 
 * that have the information from the json read into 
 * thses structures to then be accessed aqnd displayed 
 * to the user
 */
namespace LoLQueen
{
    public class Quickplay
    {
        public string Hero { get; set; }
        public string Played { get; set; }
        public string Img { get; set; }
    }

    public class Competitive
    {
        public string Hero { get; set; }
        public string Played { get; set; }
        public string Img { get; set; }
    }

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

    public class Game
    {
        public List<Quickplay8> Quickplay { get; set; }
        public List<Competitive7> Competitive { get; set; }
    }

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

    public class RootObject
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public string Portrait { get; set; }
        public Stats Stats { get; set; }
    }
}