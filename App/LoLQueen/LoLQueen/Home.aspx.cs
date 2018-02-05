﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;

namespace LoLQueen

    //this is a test comment
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitSummonerName(object sender, EventArgs e)
        {

            //get summoners name from textbox
            string summonerName = ValidateName(SummonerName.Text);

            Debug.WriteLine("summoner name contains" + summonerName);

            //get summoner info from user input through textbox
            string summonerUrl = RiotUrl.GetSummonerUrl(summonerName,"euw1");
            Summoner currentSummoner = getJsonObject<Summoner>(summonerUrl);

            Debug.WriteLine("Collected summoner info");


            //get 2o match history games
            string matchHistUrl = RiotUrl.GetMatchHistUrl("euw1",currentSummoner.AccountId.ToString());
            MatchHist matchHist = getJsonObject<MatchHist>(matchHistUrl);

            Debug.WriteLine("Collected match hist : " + matchHist.Matches[0].Champion + " and game ID = " + matchHist.Matches[0].GameId);


            //get specific match information (NEEDS TO BE LOOPED FOR LAST 20)
            List<MatchInfo.singleMatch> allMatchDetails = new List<MatchInfo.singleMatch>();

            for(int i= 0; i < 20; ++i)
            {
                string matchUrl = RiotUrl.GetMatchUrl(matchHist.Matches[i].GameId.ToString(), "euw1");

                allMatchDetails.Add(getJsonObject<MatchInfo.singleMatch>(matchUrl));
            }
            
  



            //Debug.WriteLine(" url contains = " + matchUrl);
            Debug.WriteLine("Collect match info Kills : " + allMatchDetails[0].Participants[0].Stats.Kills);
            Debug.WriteLine("SECOND GAME KILLS : " + allMatchDetails[1].Participants[0].Stats.Kills);



            //get total champion mastery
            string masteryUrl = RiotUrl.GetTotalMasteryScoreUrl(currentSummoner.Id.ToString(), "euw1");
            var mastery = new WebClient().DownloadString(masteryUrl);

            Debug.WriteLine("Collected mastery");



            //get individual champion mastery levels
            string masteryProgressUrl = RiotUrl.GetMasteryProgressUrl(currentSummoner.Id.ToString(), "euw1");
            IList<ProgressionContents> champMastery = getJsonObject<IList<ProgressionContents>>(masteryProgressUrl);

            Debug.WriteLine("Collected champ mastery");

            Debug.WriteLine("champ id from champ mastery = " + champMastery[0].championId);
            UpdatePageData(currentSummoner);

        }

        public static T getJsonObject<T>(string queryUrl)
        {
            var jsonSerializerSettings = new JsonSerializerSettings();

            //ignores json data if structure required is not present
            jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
            Debug.WriteLine("url contains : " + queryUrl);

            var jsonResult = new WebClient().DownloadString(queryUrl);
            T newObject = JsonConvert.DeserializeObject<T>(jsonResult, jsonSerializerSettings);

            return newObject;
        }


        public void UpdatePageData(Summoner currentSummoner)
        {
            summonerNameLabel.Text = currentSummoner.Name;
            summonerLevelLabel.Text = currentSummoner.SummonerLevel.ToString();
            summonerAccIdLabel.Text = currentSummoner.AccountId.ToString();
        }

        protected void RedirectOW(object sender, EventArgs e)
        {
            Response.Redirect("OwHome.aspx");
        }

        public string ValidateName(string summonerName)
        {
            string newSummonerName = summonerName.Replace(" ", "%20");

            return newSummonerName;
        }
    }
}