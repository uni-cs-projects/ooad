using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random a = new Random();
            int i = 1;
            if (!IsPostBack)
            {
                foreach (var item in new ShowLeagues().listLeagueproxy())
                {

                    leagues.InnerHtml += $@"<tr class=""click-row"" data-href=""Manageteams.aspx?lid={item.LeagueID}"">
                    <th scope =""row"">{i}</th>
 
                     <td>{item.LeagueName}</td>
    
                        <td>{a.Next(1, 100)}+</td>
    
                    </tr>";
                    i++;
                }
            }
            else
            {
                leagues.InnerHtml = "";
                foreach (var item in new ShowLeagues().listLeague())
                {

                    leagues.InnerHtml += $@"<tr class=""click-row"" data-href=""Manageteams.aspx?lid={item.LeagueID}"">
                    <th scope =""row"">{i}</th>
 
                     <td>{item.LeagueName}</td>
    
                        <td>{a.Next(1, 100)}+</td>
    
                    </tr>";
                    i++;
                }

            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {



        }
    }
}