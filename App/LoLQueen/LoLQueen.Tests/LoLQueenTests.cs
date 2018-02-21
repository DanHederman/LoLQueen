using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        
        private static string _apiKey;

        [ClassInitialize()]
        public static void InitApiTest(TestContext context)
        {
            _apiKey = "RGAPI-2ec4087b-52d8-4450-b6c2-ba35dbee6e75";
        }

        [TestMethod]
        public void Test_GetSummonerUrl_Pass()
        {
            var actual = RiotUrl.GetSummonerUrl("euw1", "Notorious%20Nutz");
            var expected = ("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Notorious%20Nutz?api_key=" + _apiKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetSummonerUrl_Fail()
        {
            var actual = RiotUrl.GetSummonerUrl("euw1", "MLPQuadzilla");
            var expected = ("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Notorious%20Nutz?api_key=" + _apiKey);
            Assert.AreNotEqual(actual, expected);
        }
        
        /// <summary>
        /// The following 2 tests check that the url for matchhist 
        /// is created successfully and also checks for failure
        /// </summary>

        [TestMethod]
        public void Test_GetMatchHistUrl_Pass()
        {
            var actual = RiotUrl.GetMatchHistUrl("euw1", "22097197");
            var expected = ("https://euw1.api.riotgames.com/lol/match/v3/matchlists/by-account/22097197/recent?api_key=" + _apiKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetMatchHistUrl_Fail()
        {
            var actual = RiotUrl.GetMatchHistUrl("euw1", "22097197");
            var expected = ("https://euw1.api.riotgames.com/lol/match/v3/matchlists/by-account/22097198/recent?api_key=" + _apiKey);
            Assert.AreNotEqual(actual, expected);
        }
        
        
        /// <summary>
        /// The following 2 tests check that the url for getmatch
        /// is created successfully and also checks for failure
        /// </summary>
        [TestMethod]
        public void Test_GetMatchUrl_Pass()
        {
            var actual = RiotUrl.GetMatchUrl("euw1", "3534917828");
            var expected = ("https://euw1.api.riotgames.com/lol/match/v3/matches/3534917828?api_key=" + _apiKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetMatchUrl_fail()
        {
            var actual = RiotUrl.GetMatchUrl("euw1", "3534917828");
            var expected = ("https://euw1.api.riotgames.com/lol/match/v3/matches/3534917827?api_key=" + _apiKey);
            Assert.AreNotEqual(actual, expected);
        }

        
        /// <summary>
        /// The following 2 tests check that the url for GetTotalMasteryScoreUrl
        /// is created successfully and also checks for failure
        /// </summary>
        [TestMethod]
        public void Test_GetTotalMasteryScoreUrl_Pass()
        {
            var actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            var expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754700?api_key=" + _apiKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetTotalMasteryScoreUrl_Fail()
        {
            var actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            var expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754707?api_key=" + _apiKey);
            Assert.AreNotEqual(actual, expected);
        }
        
        /// <summary>
        /// The following 2 tests check the success and failure 
        /// of the creation of the url to the GetMasteryProgressUrl
        /// </summary>
        [TestMethod]
         public void Test_GetMasteryProgressUrl_Pass()
        {
            var actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            var expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754700?api_key=" + _apiKey);
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Test_GetMasteryProgressUrl_Fail()
        {
            var actual = RiotUrl.GetTotalMasteryScoreUrl("euw1", "3534754700");
            var expected = ("https://euw1.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/3534754707?api_key=" + _apiKey);
            Assert.AreNotEqual(actual, expected);
        }    

        /// <summary>
        /// Test the method get stats
        /// </summary>
        [TestMethod]
        public void Test_GetStats_Pass()
        {

            var actual = JsonSettings.GetStats<Summoner>("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Notorious%20Nutz?api_key=" + _apiKey);
            var actualName = actual.Name;
            const string expected = ("Notorious Nutz");
            Assert.AreEqual(actualName, expected);
        }

        [TestMethod]
        public void Test_GetStats_Fail()
        {
            Summoner actual = JsonSettings.GetStats<Summoner>("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/kgbbí?api_key=" + _apiKey);
            var actualName = actual.Name;
            const string expected = ("Notorious Nutz");
            Assert.AreNotEqual(actualName, expected);
        }

        [TestMethod]
        public void Test_GetStats_Pass2()
        {
            var actual = JsonSettings.GetStats<Summoner>("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/MLPQuadzilla?api_key=" + _apiKey);
            var actualName = actual.Name;
            const string expected = ("MLPQuadzilla");
            Assert.AreEqual(actualName, expected);
        }
    }
}
