using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowLeagues a = new ShowLeagues();
            Random RAND = new Random();
            for (int i = 0; i < a.listLeague().Count; i++)
            {
                
                leagues.InnerHtml += @"<tr class=""click-row"" data-href=""#"">
                    <th scope=""row"">"+(i+1)+@"</th>
 
                     <td>"+a.listLeague()[i].LeagueName+@"</td>
    
                        <td>"+a.listLeague()[i].Tourname+@"</td>
       
                           <td>"+RAND.Next(20,100)+@"+</td>
       
                       </tr>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}