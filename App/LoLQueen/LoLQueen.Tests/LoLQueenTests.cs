using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace LoLQueen.Tests
{

    [TestClass]
    public class LoLQueenTests
    {
        /// <summary>
        /// The following 2 tests are to check if
        /// the creation of the url getsummoner 
        /// is successful and check for failure
        /// API key must be manyally put in
        /// </summary>
        /// 
        
        private static string APIKey;

        [ClassInitialize()]
        public static void InitApiTest(TestContext context)
        {
            APIKey = "";
        }

        [TestMethod]
        public void Test_GetSummonerUrl_Pass()
        {
            string actual = RiotUrl.GetSummonerUrl("euw1", "Notorious%20Nutz");
            string expected = ("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Notorious%20Nutz?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetSummonerUrl_Fail()
        {
            string actual = RiotUrl.GetSummonerUrl("euw1", "MLPQuadzilla");
            string expected = ("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Notorious%20Nutz?api_key=" + APIKey);
            Assert.AreNotEqual(actual, expected);
        }
        
        /// <summary>
        /// The following 2 tests check that the url for matchhist 
        /// is created successfully and also checks for failure
        /// </summary>

        [TestMethod]
        public void Test_GetMatchHistUrl_Pass()
        {
            string actual = RiotUrl.GetMatchHistUrl("euw1", "22097197");
            string expected = ("https://euw1.api.riotgames.com/lol/match/v3/matchlists/by-account/22097197/recent?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetMatchHistUrl_Fail()
        {
            string actual = RiotUrl.GetMatchHistUrl("euw1", "22097197");
            string expected = ("https://euw1.api.riotgames.com/lol/match/v3/matchlists/by-account/22097198/recent?api_key=" + APIKey);
            Assert.AreNotEqual(actual, expected);
        }
        
        
        /// <summary>
        /// The following 2 tests check that the url for getmatch
        /// is created successfully and also checks for failure
        /// </summary>
        [TestMethod]
        public void Test_GetMatchUrl_Pass()
        {
            string actual = RiotUrl.GetMatchUrl("euw1", "3534917828");
            string expected = ("https://euw1.api.riotgames.com/lol/match/v3/matches/3534917828?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetMatchUrl_fail()
        {
            string actual = RiotUrl.GetMatchUrl("euw1", "3534917828");
            string expected = ("https://euw1.api.riotgames.com/lol/match/v3/matches/3534917827?api_key=" + APIKey);
            Assert.AreNotEqual(actual, expected);
        }

        
        /// <summary>
        /// The following 2 tests check that the url for GetTotalMasteryScoreUrl
        /// is created successfully and also checks for failure
        /// </summary>
        [TestMethod]
        public void Test_GetTotalMasteryScoreUrl_Pass()
        {
            string actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            string expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754700?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetTotalMasteryScoreUrl_Fail()
        {
            string actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            string expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754707?api_key=" + APIKey);
            Assert.AreNotEqual(actual, expected);
        }
        
        /// <summary>
        /// The following 2 tests check the success and failure 
        /// of the creation of the url to the GetMasteryProgressUrl
        /// </summary>
        [TestMethod]
         public void Test_GetMasteryProgressUrl_Pass()
        {
            string actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            string expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754700?api_key=" + APIKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetMasteryProgressUrl_Fail()
        {
            string actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            string expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754707?api_key=" + APIKey);
            Assert.AreNotEqual(actual, expected);
        }    

        /// <summary>
        /// Test the method get stats
        /// </summary>
        [TestMethod]
        public void Test_GetStats_Pass()
        {

            Summoner actual = JsonSettings.GetStats<Summoner>("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Notorious%20Nutz?api_key=" + APIKey.ToString());
            string actualName = actual.Name;
            string expected = ("Notorious Nutz");
            Assert.AreEqual(actualName, expected);
        }

        [TestMethod]
        public void Test_GetStats_Fail()
        {
            Summoner actual = JsonSettings.GetStats<Summoner>("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/kgbbí?api_key=" + APIKey);
            string actualName = actual.Name;
            string expected = ("Notorious Nutz");
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetStats_Pass2()
        {
            Summoner actual = JsonSettings.GetStats<Summoner>("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/MLPQuadzilla?api_key=" + APIKey.ToString());
            string actualName = actual.Name;
            string expected = ("MLPQuadzilla");
            Assert.AreEqual(actualName, expected);
        }
    }
}
