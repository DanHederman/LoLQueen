using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;

namespace LoLQueen

    
{
    public partial class Home : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //get static LoL info

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SubmitSummonerName(object sender, EventArgs e)
        {

            //get summoners name from textbox
            string summonerName = ValidateName(SummonerName.Text);

            //get summoner info from user input through textbox
            Summoner currentSummoner = Summoner.GetSummonerInfo("euw1", summonerName);


            //get 20 match history games
            MatchHist matchHist = MatchHist.GetMatchHistory("euw1", currentSummoner.AccountId.ToString());
            


            //get specific match information (NEEDS TO BE LOOPED FOR LAST 20)
            List<MatchInfo.singleMatch> allMatchDetails = new List<MatchInfo.singleMatch>();
            allMatchDetails = MatchInfo.GetMatchDetails("euw1", matchHist);


            //get total champion mastery
            string masteryUrl = RiotUrl.GetTotalMasteryScoreUrl(currentSummoner.Id.ToString(), "euw1");
            var mastery = new WebClient().DownloadString(masteryUrl);

            //get individual champion mastery levels
            string masteryProgressUrl = RiotUrl.GetMasteryProgressUrl(currentSummoner.Id.ToString(), "euw1");
            IList<ProgressionContents> champMastery = JsonSettings.GetStats<IList<ProgressionContents>>(masteryProgressUrl);

            UpdatePageData(currentSummoner);

        }
        
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentSummoner"></param>
        public void UpdatePageData(Summoner currentSummoner)
        {
            summonerNameLabel.Text = currentSummoner.Name;
            summonerLevelLabel.Text = currentSummoner.SummonerLevel.ToString();
            summonerAccIdLabel.Text = currentSummoner.AccountId.ToString();
        }

        /// <summary>
        /// Redirect to OverWatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RedirectOW(object sender, EventArgs e)
        {
            Response.Redirect("OwHome.aspx");
        }

        /// <summary>
        /// Replace the space in summonerName to ensure 
        /// successful link creation
        /// </summary>
        /// <param name="summonerName"></param>
        /// <returns></returns>
        public string ValidateName(string summonerName)
        {
            string newSummonerName = summonerName.Replace(" ", "%20");

            return newSummonerName;
        }
    }
}