using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace LoLQueen
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitSummonerName(object sender, EventArgs e)
        {


            string jsonUrl = RiotUrl.GetSummonerUrl(SummonerName.Text,"euw1");

            //call method to check characters

            System.Diagnostics.Debug.WriteLine("url contains " + jsonUrl);

            var json = new WebClient().DownloadString(jsonUrl);

            Summoner currentSummoner = JsonConvert.DeserializeObject<Summoner>(json);

            string matchHistUrl = RiotUrl.GetMatchHistUrl("euw1",currentSummoner.AccountId.ToString());

            System.Diagnostics.Debug.WriteLine("Match hist url contains " + matchHistUrl);

            json = new WebClient().DownloadString(matchHistUrl);

            MatchHist matchHist = JsonConvert.DeserializeObject<MatchHist>(json);

            System.Diagnostics.Debug.WriteLine(matchHist.TotalGames);
            //call method to gain match history info and other info
            UpdatePageData(currentSummoner);

        }
        public void UpdatePageData(Summoner currentSummoner)
        {
            summonerNameLabel.Text = currentSummoner.Name;
            summonerLevelLabel.Text = currentSummoner.SummonerLevel.ToString();
            summonerAccIdLabel.Text = currentSummoner.AccountId.ToString();
        }

    }
}