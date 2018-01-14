using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoLQueen
{
    public partial class OwHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedirectToLoL(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void RedirectHome(object sender, EventArgs e)
        {
            
        }

        protected void DataGen(object sender, EventArgs e)
        {
            string heroName = HeroName.Text;
            string heroTag = HeroTag.Text;

            string blizzardUrl = OwUrl.OverwatchUrl(heroName, heroTag);

            Debug.WriteLine("Full URL is: ");
            Debug.WriteLine(blizzardUrl);
        }
    }
}