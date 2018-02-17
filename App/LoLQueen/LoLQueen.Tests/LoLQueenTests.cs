using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoLQueen.Tests
{

    [TestClass]
    public class LoLQueenTests
    {
        /*
         * The following 2 tests are to check if 
         * the creation of the url getsummoner 
         * is successful and check for failure
         * API key must be manyally put in
         */

        public static string APIKey;

         [TestInitialize]
         public void setKey()
        {
            string APIKey = "";
        }

        [TestMethod]
        public void Test_GetSummonerUrl_Pass()
        {
            string actual = RiotUrl.GetSummonerUrl("", "");
            string expected = ("https://{region}.api.riotgames.com/lol/summoner/v3/summoners/by-name/{username}?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetSummonerUrl_Fail()
        {
            string actual = RiotUrl.GetSummonerUrl("", "");
            string expected = ("https://{region}.api.riotgames.com/lol/summoner/v3/summoners/by-name/{username}?api_key=" + APIKey) ;
            Assert.AreNotEqual(actual, expected);
        }

        /*
         * The following 2 tests check that the url for matchhist 
         * is created successfully and also checks for failure
         */

        [TestMethod]
        public void Test_GetMatchHistUrl_Pass()
        {
            string actual = RiotUrl.GetMatchHistUrl("", "");
            string expected = ("https://{region}.api.riotgames.com/lol/match/v3/matchlists/by-account/{accid}/recent?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetMatchHistUrl_Fail()
        {
            string actual = RiotUrl.GetMatchHistUrl("", "");
            string expected = ("https://{region}.api.riotgames.com/lol/match/v3/matchlists/by-account/{accid}/recent?api_key=" + APIKey);
            Assert.AreNotEqual(actual, expected);
        }

        /*
         * The following 2 tests check that the url for matchhist 
         * is created successfully and also checks for failure
         */

        [TestMethod]
        public void Test_GetMatchUrl()
        {
            string actual = RiotUrl.GetMatchUrl("", "");
            string expected = ("https://{region}.api.riotgames.com/lol/match/v3/matches/{gameId}?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetMatchUrl_fail()
        {
            string actual = RiotUrl.GetMatchUrl("", "");
            string expected = ("https://{region}.api.riotgames.com/lol/match/v3/matches/{gameId}?api_key=" + APIKey);
            Assert.AreNotEqual(actual, expected);
        }
    }
}
