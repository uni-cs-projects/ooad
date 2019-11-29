using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;
using WebApplication6.Entity;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Leagues a = new Leagues();
            a.userid = Convert.ToInt32(Session["id"]);
            Random RAND = new Random();
            for (int i = 0; i < a.showLeagues().Count; i++)
            {
                if (!Page.IsPostBack)
                {
                    leagCreate.InnerHtml += @"<tr class=""click-row"" data-href=""#"">
                    <th scope=""row"">" + (i + 1) + @"</th>
 
                     <td>" + a.showLeagues()[i].LeagueName + @"</td>
    
                        <td>" + a.showLeagues()[i].Tourname + @"</td>
       
                           <td>" + RAND.Next(20, 100) + @"+</td>
       
                       </tr>";
                }
            }
            int j = 0;
            foreach (var item in new ParticipantsManager().JoinedLeagues(Convert.ToInt32(Session["id"])))
            {
                if (!Page.IsPostBack)
                {
                     leaguesP.InnerHtml += @"<tr class=""click-row"" data-href=""#"">
                    <th scope=""row"">" + (j + 1) + @"</th>
 
                     <td>" + item.LeagueName + @"</td>
    
                        <td>" + item.Tourname + @"</td>
       
                           <td>" + RAND.Next(20, 100) + @"+</td>
       
                       </tr>";
                    j++;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Leagues.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaguesCreater.aspx");
        }
    }
}