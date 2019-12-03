using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var item in new LeaguesSelector().showResults(Convert.ToInt32(Session["id"])))
            {
                result.InnerHtml += $@"<tr>
                    <th scope=""row"">{i+1}</th>
                    <td>{item.LeagueName}</td>
                    <td>{item.sum}</td>
                </tr>";
                i++;
            }
  
        }
    }
}