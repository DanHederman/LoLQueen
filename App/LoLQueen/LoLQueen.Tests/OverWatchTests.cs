using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LoLQueen.Tests
{
    [TestClass]
    public class OverWatchTests
    {
        /// <summary>
        /// Initialize 
        /// </summary>
        [TestInitialize]
        public void fillStruct()
        {

        }
      
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
            string actual = BlizzardUrl.ConnectToBlizzard("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/stats/pc/us/Quadzilla-21122";
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
            string actual = BlizzardUrl.ConnectToBlizzard("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/stats/pc/us/cathal1k97-2203";
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
            string actual = BlizzardUrl.ConnectToBlizzard2("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122";
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
            string actual = BlizzardUrl.ConnectToBlizzard2("Quadzilla", "21122");
            string expected = "https://ow-api.herokuapp.com/profile/pc/us/cathal1k97-2203";
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test the method to read in the json 
        /// file to the structs
        /// </summary>

        [TestMethod]
        public void Test_Struct()
        {
            string actual= Home.GetStats<string>("https://ow-api.herokuapp.com/profile/pc/us/Quadzilla-21122");
            string expected = null;

            System.Diagnostics.Debug.WriteLine("String actual is: " + actual);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Test_UpdatePageData()
        {
            string actual = null;
        }
        
    }
}