using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoLQueen
{
    public partial class GameSelect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedirectLoL(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void RedirectOW(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("OwHome.aspx");
        }
    }
}