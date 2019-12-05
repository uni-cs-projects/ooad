using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var item in new ManagerMatches().getMatchList())
            {
                dl.Items.Add(new ListItem(item.matchname,item.matchid.ToString()));
            }

            foreach (var item in new PlayersManager().getPlayer())
            {
                DropDownList1.Items.Add(new ListItem(item.playerName,item.playerid.ToString()));
            }
            

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

           new PointsAdder().addPoints(Convert.ToInt32(dl.SelectedValue), Convert.ToInt32(DropDownList1.SelectedValue), Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox4.Text));
            Response.Write("<script>alert('Points Added')</script>");
        }
    }
}