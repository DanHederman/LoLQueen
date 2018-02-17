using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoLQueen.Tests
{
    [TestClass]
    public class LoLQueenTests
    {
        [TestMethod]
        public void Test_GetSummonerUrl_Pass()
        {
            string actual = RiotUrl.GetSummonerUrl("", "", "");
            string expected = "";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetSummonerUrl_Fail()
        {
            string actual = RiotUrl.GetSummonerUrl("", "", "");
            string expected = "https://{region}.api.riotgames.com/lol/summoner/v3/summoners/by-name/{username}?api_key={apiKey}";
            Assert.AreNotEqual(actual, expected);
        }
    }
}
