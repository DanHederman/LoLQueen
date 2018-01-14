using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLQueen
{
    public class OwUrl
    {
        public static string OverwatchUrl(string username, string usertag)
        {
            var blizzardUrl = string.Format("https://" + "ow-api.herokuapp.com/stats/pc/us/" + username + "-" + usertag);

            return blizzardUrl;
        }
    }
}