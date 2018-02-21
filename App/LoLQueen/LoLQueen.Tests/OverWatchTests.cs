using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LoLQueen.Tests
{
    [TestClass]
    public class OverWatchTests
    {
        /// <summary>
        /// Test the method to create the link 
        /// to the large json file
        /// <remark>
        /// test is for a successfully made url 
        /// </remark>
        /// </summary>
        [TestMethod]
        public void Test_Large_Url_Pass()
        {
            var actual = BlizzardUrl.ConnectToBlizzard("Quadzilla", "21122");
            const string expected = "https://ow-api.herokuapp.com/stats/pc/us/Quadzilla-21122";
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test the method to create the link
        /// for the large json file
        /// <remark>
        /// test is for a bad match
        /// </remark>
        /// </summary>

        [TestMethod]
        public void Test_Large_URL_Fail()
        {
            var actual = BlizzardUrl.ConnectToBlizzard("Quadzilla", "21122");
            const string expected = "https://ow-api.herokuapp.com/stats/pc/us/cathal1k97-2203";
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test for a successfully created json file
        /// <remarks>
        /// Test is for a successfully created url
        /// </remarks>
        /// </summary>
        [TestMethod]
        public void Test_Small_URL_Pass()
        {
            var actual = BlizzardUrl.ConnectToBlizzard2("Quadzilla", "21122");
            const string expected = "https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122";
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test the method to create the link
        /// for the small json file
        /// <remarks>
        /// The test is for an unsuccessfully created link
        /// </remarks>
        /// </summary>
        [TestMethod]
        public void Test_Small_URL_Fail()
        {
            var actual = BlizzardUrl.ConnectToBlizzard2("Quadzilla", "21122");
            const string expected = "https://ow-api.herokuapp.com/profile/pc/us/cathal1k97-2203";
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test the method to read in the json 
        /// file to the large struct
        /// </summary>

        [TestMethod]
        public void Test_Struct_Hero()
        {
            var actual = JsonSettings.GetStats<RootObject>("https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122");
            var actualName = actual.Username;
            const string expected = ("Quadzilla");
            Assert.AreEqual(expected, actualName);
        }
        
        [TestMethod]
        public void Test_GetStats_Struct_Hero_End()
        {
            RootObject actual = JsonSettings.GetStats<RootObject>("https://ow-api.herokuapp.com/stats/pc/us/Quadzilla-21122");
            var actualString = actual.Portrait;
            const string expected = ("https://d1u1mce87gyfbn.cloudfront.net/game/unlocks/0x0250000000000BB8.png");
            Assert.AreEqual(actualString, expected);
        }       

        /// <summary>
        /// Test the method to read in the json
        /// file to the small struct
        /// </summary>
        [TestMethod]
        public void Test_GetStats_struct_Hero2()
        {
            var actual = JsonSettings.GetStats<Root>("https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122");
            var actualString = actual.Username;
            const string expected = "Quadzilla";
            Assert.AreEqual(actualString, expected);
        }

        [TestMethod]
        public void Test_getStats_struct_Hero2_End()
        {
            var actual = JsonSettings.GetStats<Root>("https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122");
            var actualString = actual.Portrait;
            const string expected = "https://d1u1mce87gyfbn.cloudfront.net/game/unlocks/0x0250000000000BB8.png";
            Assert.AreEqual(actualString, expected);
        }
    }
}