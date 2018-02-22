using System;
using System.Diagnostics;

namespace LoLQueen
{
    public partial class OwHome : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Redirect to LoLQueen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RedirectToLoL(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void RedirectHome(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DataGen(object sender, EventArgs e)
        {
            var username = HeroNameBox.Text;
            var usernum = HeroTag.Text;
            

            var obj = BlizzardUrl.ConnectToBlizzard(username, usernum);
            var obj2 = BlizzardUrl.ConnectToBlizzard2(username, usernum);
            
            var currentHero = JsonSettings.GetStats<RootObject>(obj);
            var currentHero2 = JsonSettings.GetStats<Root>(obj2);
            

            UpdatePageData(currentHero, currentHero2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentHero"></param>
        /// <param name="currentHero2"></param>
        public void UpdatePageData(RootObject currentHero, Root currentHero2)
        {
            if (currentHero == null)
            {
                throw new ArgumentNullException(nameof(currentHero));
            }
            else if (currentHero2 == null)
            {
                throw new ArgumentNullException(nameof(currentHero2));
            }

            else
            {
                try
                {
                    HeroName.Text = currentHero.Username;
                    HeroLevel.Text = currentHero.Level.ToString();
                    PlayerImg.ImageUrl = currentHero.Portrait;
                    QuickWin.Text = currentHero2.Games.Quickplay.Won.ToString();
                    RankImg.ImageUrl = currentHero2.Competitive.RankImg;
                    CompWin.Text = currentHero2.Games.Competitive.Won.ToString();
                    
                    //Quickplay top herpoes
                    TopHeroesLabel1.Text = currentHero.Stats.top_heroes.Quickplay[0].Hero;
                    TopHeroesLabel2.Text = currentHero.Stats.top_heroes.Quickplay[1].Hero;
                    TopHeroesLabel3.Text = currentHero.Stats.top_heroes.Quickplay[2].Hero;
                    TopHeroesLabel4.Text = currentHero.Stats.top_heroes.Quickplay[3].Hero;
                    TopHeroesLabel5.Text = currentHero.Stats.top_heroes.Quickplay[4].Hero;

                    //Competitive top heroes
                    TopHeroLabel1.Text = currentHero.Stats.top_heroes.Competitive[0].Hero;
                    TopHeroLabel2.Text = currentHero.Stats.top_heroes.Competitive[1].Hero;
                    TopHeroLabel3.Text = currentHero.Stats.top_heroes.Competitive[2].Hero;
                    TopHeroLabel4.Text = currentHero.Stats.top_heroes.Competitive[3].Hero;
                    TopHeroLabel5.Text = currentHero.Stats.top_heroes.Competitive[4].Hero;

                    AssistsLabel.Text = currentHero.Stats.Assists.Quickplay[0].Value;
                    CompAssistsLabel1.Text = currentHero.Stats.Assists.Competitive[0].Value;

                    CombatQuickLabel.Text = currentHero.Stats.Combat.Quickplay[0].Title;
                    CombatQuickLabel1.Text = currentHero.Stats.Combat.Quickplay[0].Value;

                    CombatCompLabel.Text = currentHero.Stats.Combat.Competitive[0].Title;
                    CombatCompLabel1.Text = currentHero.Stats.Combat.Competitive[0].Value;

                    GameQuickLabel.Text = currentHero.Stats.Game.Quickplay[0].Title;
                    GameQuickLabel1.Text = currentHero.Stats.Game.Quickplay[0].Value;

                    GameCompLabel.Text = currentHero.Stats.Game.Competitive[0].Title;
                    GameCompLabel1.Text = currentHero.Stats.Game.Competitive[0].Value;

                    Match_AwardsQuickLabel.Text = currentHero.Stats.MatchAwards.Quickplay[0].Title;
                    Match_AwardsQuickLabel1.Text = currentHero.Stats.MatchAwards.Quickplay[0].Value;

                    Match_AwardsCompLabel.Text = currentHero.Stats.MatchAwards.Competitive[0].Title;
                    Match_AwardsCompLabel1.Text = currentHero.Stats.MatchAwards.Competitive[0].Value;

                    MiscQuickLabel.Text = currentHero.Stats.Miscellaneous.Quickplay[0].Title;
                    MiscQuickLabel1.Text = currentHero.Stats.Miscellaneous.Quickplay[0].Value;

                    MiscCompLabel.Text = currentHero.Stats.Miscellaneous.Quickplay[0].Title;
                    MiscCompLabel1.Text = currentHero.Stats.Miscellaneous.Quickplay[0].Value;
                    // ----------------------------------------------------------------------------------------------------------

                    AssistsLabel1.Text = currentHero.Stats.Assists.Quickplay[1].Value;
                    CompAssistsLabel19.Text = currentHero.Stats.Assists.Competitive[1].Value;

                    CombatQuickLabel1.Text = currentHero.Stats.Combat.Quickplay[1].Title;
                    CombatQuickLabel11.Text = currentHero.Stats.Combat.Quickplay[1].Value;

                    CombatCompLabel1.Text = currentHero.Stats.Combat.Competitive[1].Title;
                    CombatCompLabel19.Text = currentHero.Stats.Combat.Competitive[1].Value;

                    GameQuickLabel1.Text = currentHero.Stats.Game.Quickplay[1].Title;
                    GameQuickLabel11.Text = currentHero.Stats.Game.Quickplay[1].Value;

                    GameCompLabel1.Text = currentHero.Stats.Game.Competitive[1].Title;
                    GameCompLabel19.Text = currentHero.Stats.Game.Competitive[1].Value;

                    Match_AwardsQuickLabel1.Text = currentHero.Stats.MatchAwards.Quickplay[1].Title;
                    Match_AwardsQuickLabel11.Text = currentHero.Stats.MatchAwards.Quickplay[1].Value;

                    Match_AwardsCompLabel1.Text = currentHero.Stats.MatchAwards.Competitive[1].Title;
                    Match_AwardsCompLabel19.Text = currentHero.Stats.MatchAwards.Competitive[1].Value;

                    MiscQuickLabel1.Text = currentHero.Stats.Miscellaneous.Quickplay[1].Title;
                    MiscQuickLabel11.Text = currentHero.Stats.Miscellaneous.Quickplay[1].Value;

                    MiscCompLabel1.Text = currentHero.Stats.Miscellaneous.Quickplay[1].Title;
                    MiscCompLabel19.Text = currentHero.Stats.Miscellaneous.Quickplay[1].Value;

                    //-------------------------------------------------------------------------------------------------------------------------------

                    AssistsLabel2.Text = currentHero.Stats.Assists.Quickplay[2].Value;
                    CompAssistsLabel18.Text = currentHero.Stats.Assists.Competitive[2].Value;

                    CombatQuickLabel2.Text = currentHero.Stats.Combat.Quickplay[2].Title;
                    CombatQuickLabel12.Text = currentHero.Stats.Combat.Quickplay[2].Value;

                    CombatCompLabel8.Text = currentHero.Stats.Combat.Competitive[2].Title;
                    CombatCompLabel18.Text = currentHero.Stats.Combat.Competitive[2].Value;

                    GameQuickLabel2.Text = currentHero.Stats.Game.Quickplay[2].Title;
                    GameQuickLabel12.Text = currentHero.Stats.Game.Quickplay[2].Value;

                    GameCompLabel8.Text = currentHero.Stats.Game.Competitive[2].Title;
                    GameCompLabel18.Text = currentHero.Stats.Game.Competitive[2].Value;

                    Match_AwardsQuickLabel2.Text = currentHero.Stats.MatchAwards.Quickplay[2].Title;
                    Match_AwardsQuickLabel12.Text = currentHero.Stats.MatchAwards.Quickplay[2].Value;

                    Match_AwardsCompLabel8.Text = currentHero.Stats.MatchAwards.Competitive[2].Title;
                    Match_AwardsCompLabel18.Text = currentHero.Stats.MatchAwards.Competitive[2].Value;

                    MiscQuickLabel2.Text = currentHero.Stats.Miscellaneous.Quickplay[2].Title;
                    MiscQuickLabel12.Text = currentHero.Stats.Miscellaneous.Quickplay[2].Value;

                    MiscCompLabel8.Text = currentHero.Stats.Miscellaneous.Quickplay[2].Title;
                    MiscCompLabel18.Text = currentHero.Stats.Miscellaneous.Quickplay[2].Value;
                    //------------------------------------------------------------------------------------------------------------------------------------

                    AssistsLabel3.Text = currentHero.Stats.Assists.Quickplay[3].Value;
                    CompAssistsLabel17.Text = currentHero.Stats.Assists.Competitive[3].Value;

                    CombatQuickLabel3.Text = currentHero.Stats.Combat.Quickplay[3].Title;
                    CombatQuickLabel13.Text = currentHero.Stats.Combat.Quickplay[3].Value;

                    CombatCompLabel7.Text = currentHero.Stats.Combat.Competitive[3].Title;
                    CombatCompLabel17.Text = currentHero.Stats.Combat.Competitive[3].Value;

                    GameQuickLabel3.Text = currentHero.Stats.Game.Quickplay[3].Title;
                    GameQuickLabel13.Text = currentHero.Stats.Game.Quickplay[3].Value;

                    GameCompLabel7.Text = currentHero.Stats.Game.Competitive[3].Title;
                    GameCompLabel17.Text = currentHero.Stats.Game.Competitive[3].Value;

                    Match_AwardsQuickLabel3.Text = currentHero.Stats.MatchAwards.Quickplay[3].Title;
                    Match_AwardsQuickLabel13.Text = currentHero.Stats.MatchAwards.Quickplay[3].Value;

                    Match_AwardsCompLabel7.Text = currentHero.Stats.MatchAwards.Competitive[3].Title;
                    Match_AwardsCompLabel17.Text = currentHero.Stats.MatchAwards.Competitive[3].Value;

                    MiscQuickLabel3.Text = currentHero.Stats.Miscellaneous.Quickplay[3].Title;
                    MiscQuickLabel13.Text = currentHero.Stats.Miscellaneous.Quickplay[3].Value;

                    MiscCompLabel7.Text = currentHero.Stats.Miscellaneous.Quickplay[3].Title;
                    MiscCompLabel17.Text = currentHero.Stats.Miscellaneous.Quickplay[3].Value;
                    //-----------------------------------------------------------------------------------------------------------------------------------------

                    AssistsLabel4.Text = currentHero.Stats.Assists.Quickplay[4].Value;
                    CompAssistsLabel16.Text = currentHero.Stats.Assists.Competitive[4].Value;

                    CombatQuickLabel4.Text = currentHero.Stats.Combat.Quickplay[4].Title;
                    CombatQuickLabel14.Text = currentHero.Stats.Combat.Quickplay[4].Value;

                    CombatCompLabel6.Text = currentHero.Stats.Combat.Competitive[4].Title;
                    CombatCompLabel16.Text = currentHero.Stats.Combat.Competitive[4].Value;

                    GameQuickLabel4.Text = currentHero.Stats.Game.Quickplay[4].Title;
                    GameQuickLabel14.Text = currentHero.Stats.Game.Quickplay[4].Value;

                    GameCompLabel6.Text = currentHero.Stats.Game.Competitive[4].Title;
                    GameCompLabel16.Text = currentHero.Stats.Game.Competitive[4].Value;

                    Match_AwardsQuickLabel4.Text = currentHero.Stats.MatchAwards.Quickplay[4].Title;
                    Match_AwardsQuickLabel14.Text = currentHero.Stats.MatchAwards.Quickplay[4].Value;

                    Match_AwardsCompLabel6.Text = currentHero.Stats.MatchAwards.Competitive[4].Title;
                    Match_AwardsCompLabel16.Text = currentHero.Stats.MatchAwards.Competitive[4].Value;

                    MiscQuickLabel4.Text = currentHero.Stats.Miscellaneous.Quickplay[4].Title;
                    MiscQuickLabel14.Text = currentHero.Stats.Miscellaneous.Quickplay[4].Value;

                    MiscCompLabel6.Text = currentHero.Stats.Miscellaneous.Quickplay[2].Title;
                    MiscCompLabel16.Text = currentHero.Stats.Miscellaneous.Quickplay[2].Value;
                }
                catch
                {
                    Debug.WriteLine(message: "Error occured: Could not assign data from structures in Hero and Hero2 to GUI");
                }
            }
        }
    }
}