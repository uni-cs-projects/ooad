using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Entity;

namespace WebApplication6
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (pwd.Value == "shazad" && user.Value == "shazad") {
                FormsAuthentication.SetAuthCookie(user.Value, false);
               Response.Redirect(FormsAuthentication.GetRedirectUrl(user.Value, false));
              
            }
        }
    }
}