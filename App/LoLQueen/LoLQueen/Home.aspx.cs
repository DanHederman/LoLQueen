using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

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

            //get 2o match history games
            MatchHist matchHist = MatchHist.GetMatchHistory("euw1", currentSummoner.AccountId.ToString());
         


            //get specific match information (NEEDS TO BE LOOPED FOR LAST 20)
            List<MatchInfo.SingleMatch> allMatchDetails = new List<MatchInfo.SingleMatch>();
            allMatchDetails = MatchInfo.GetMatchDetails("euw1", matchHist);

            //get total champion mastery
            string masteryUrl = RiotUrl.GetTotalMasteryScoreUrl("euw1", currentSummoner.Id.ToString());
            var mastery = new WebClient().DownloadString(masteryUrl);

            //get individual champion mastery levels
            string masteryProgressUrl = RiotUrl.GetMasteryProgressUrl("euw1", currentSummoner.Id.ToString());
            IList<ProgressionContents> champMastery = JsonSettings.GetStats<IList<ProgressionContents>>(masteryProgressUrl);


            LiveGame.LiveGameData inGameData = new LiveGame.LiveGameData();
            try
            {
                inGameData = LiveGame.GetLiveGame("euw1", currentSummoner.Id.ToString());
                UpdateLiveGame();
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine("No live game data available");
            }

            UpdatePageData(currentSummoner);
            UpdateGrid(matchHist,allMatchDetails);

        }
        public void GetSummonerImg(string iconId, Summoner currentSummoner)
        {
            string imgid =
                $"http://ddragon.leagueoflegends.com/cdn/6.24.1/img/profileicon/{iconId}.png";

            ChampionImg.ImageUrl = imgid;

        }

        public void UpdateLiveGame()
        {
            //UserGameStatusLabel.Text =
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentSummoner"></param>
        public void UpdatePageData(Summoner currentSummoner)
        {
            var iconId = currentSummoner.ProfileIconId.ToString();
            summonerNameLabel.Text = currentSummoner.Name;
            summonerLevelLabel.Text = currentSummoner.SummonerLevel.ToString();
            summonerAccIdLabel.Text = currentSummoner.AccountId.ToString();
            SummonerImg.Text = currentSummoner.ProfileIconId.ToString();
            



        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchHist"></param>
        /// <param name="allMatchDetails"></param>
        public void UpdateGrid(MatchHist matchHist, List<MatchInfo.SingleMatch> allMatchDetails)
        {
            TotalGamesLabel.Text = matchHist.TotalGames.ToString();
            foreach (var item in matchHist.Matches)
            {
                LaneLabel.Text = matchHist.Matches[0].Lane;
                SummonerRoleLabel.Text = matchHist.Matches[0].Role;
                ChampionLabel.Text = matchHist.Matches[0].Champion.ToString();
            }

            foreach (var item in allMatchDetails)
            {
                KillsLabel.Text = allMatchDetails[0].Participants[0].Stats.Kills.ToString();
                DeathsLabel.Text = allMatchDetails[0].Participants[0].Stats.Deaths.ToString();
                AssistsLabel.Text = allMatchDetails[0].Participants[0].Stats.Assists.ToString();
                VisionScoreLabel.Text = allMatchDetails[0].Participants[0].Stats.VisionScore.ToString();
                DamageDealtToObjectivesLabel.Text = allMatchDetails[0].Participants[0].Stats.DamageDealtToObjectives.ToString();
                TotalDamageDealtToChampionsLabel.Text = allMatchDetails[0].Participants[0].Stats.TotalDamageDealtToChampions.ToString();
                TotalDamageTakenLabel.Text = allMatchDetails[0].Participants[0].Stats.TotalDamageTaken.ToString();
                Item1Label.Text = allMatchDetails[0].Participants[0].Stats.Item0.ToString();
                Item2Label.Text = allMatchDetails[0].Participants[0].Stats.Item1.ToString();
                Item3Label.Text = allMatchDetails[0].Participants[0].Stats.Item2.ToString();
                Item4Label.Text = allMatchDetails[0].Participants[0].Stats.Item3.ToString();
                Item5Label.Text = allMatchDetails[0].Participants[0].Stats.Item4.ToString();
                Item6Label.Text = allMatchDetails[0].Participants[0].Stats.Item5.ToString();
                Item7Label.Text = allMatchDetails[0].Participants[0].Stats.Item6.ToString();
                //UserGameStatusLabel.Text = 
            }


        }     

        /// <summary>
        /// Redirect to OverWatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RedirectOw(object sender, EventArgs e)
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