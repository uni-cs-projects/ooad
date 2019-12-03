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
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            form.Visible = false;
            if (!Page.IsPostBack)
            {


                if (new Leagues().showadminLeagues(Convert.ToInt32(Session["id"])).Count > 0)
                {
                    form.Visible = true;
                    foreach (var item in new Leagues().showadminLeagues(Convert.ToInt32(Session["id"])))
                    {
                        dl.Items.Add(new ListItem(item.LeagueName, item.LeagueID.ToString()));
                    }

                }
                foreach (var item in new ShowAnnoucements().listAnn(Convert.ToInt32(Session["id"])).OrderBy(x => x.date))
                {
                    msg.InnerHtml += $@"<tr>
                    <th scope=""row"">{item.date}</th>
                        <td>{item.leagueName}</td>
                        <td>{item.msg}</td>
                        </tr>";
                }
            }
      
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (tx.Text != "")
            {
                new GanerateAnnoucements().genAnn(Convert.ToInt32(dl.SelectedValue), tx.Text);
                Response.Redirect(Request.Url.ToString());
            }
          
         
        }
    }
}