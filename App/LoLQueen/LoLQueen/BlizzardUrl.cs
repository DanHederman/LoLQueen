using static System.String;

namespace LoLQueen
{
    public class BlizzardUrl
    {
        /// <summary>
        /// First large json, some information missing
        /// </summary>
        /// <param name="username"></param>
        /// <param name="usernum"></param>
        /// <returns></returns>

        public static string ConnectToBlizzard(string username, string usernum)
        {
            var blizzardUrl = Format("https://" + "ow-api.herokuapp.com/stats/pc/us/" + username + "-" + usernum);

            return blizzardUrl;
        }

        /// <summary>
        /// Second smaller json, information the first was missing
        /// </summary>
        /// <param name="username"></param>
        /// <param name="usernum"></param>
        /// <returns></returns>

        public static string ConnectToBlizzard2(string username, string usernum)
        {
            var blizzardUrl = Format("https://" + "ow-api.herokuapp.com/profile/pc/us/" + username + "-" + usernum);
            
            return blizzardUrl;
        }
    }
}