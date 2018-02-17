using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoLQueen;

namespace LoLQueen.Tests
{
    [TestClass]
    public class OverWatchTests
    {
        /*
         * The following 2 tests will test
         * the link to the large json file 
         * is being created successfully and 
         * will also test for failure also 
         */

        [TestMethod]
        public void Test_Large_Url_Pass()
        {
            string actual = BlizzardUrl.ConnectToBlizzard("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/stats/pc/us/Quadzilla-21122";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Large_URL_Fail()
        {
            string actual = BlizzardUrl.ConnectToBlizzard("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/stats/pc/us/cathal1k97-2203";
            Assert.AreNotEqual(expected, actual);
        }

        /*
         * The next 2 tests will test the url to the small
         * json file is being created both successfully 
         * and will also test for failure
         */

        [TestMethod]
        public void Test_Small_URL_Pass()
        {
            string actual = BlizzardUrl.ConnectToBlizzard2("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Small_URL_Fail()
        {
            string actual = BlizzardUrl.ConnectToBlizzard2("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/profile/pc/us/cathal1k97-2203";
            Assert.AreNotEqual(expected, actual);
        }

        //Test method getStats

        [TestMethod]
        public void Test_Struct()
        {
            string actual= Home.GetStats<string>("https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122");
            string expected = null;

            System.Diagnostics.Debug.WriteLine("String actual is: " + actual);
            Assert.AreEqual(expected, actual);
        }
        /*
        [TestMethod]
        public void Test_UpdatePageData()
        {
            string actual = 
        }
        */
    }
}