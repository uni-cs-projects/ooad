using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            foreach (string key in Request.Form.AllKeys)
            {
                a.Add(Request.Form[key]);
               
            }
          
            if (a.Count > 0)
            {
                new ParticipantsManager().addTeam(Convert.ToInt32(Session["id"]), Convert.ToInt32(Session["lid"]), "shazad1", a);
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Response.Redirect("Manageteams.aspx");
            }

        }
    }
}