using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Entity;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /// string a = Request.Form["fname"];
          ///  Response.Write(a);
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            VerifyUser check = new VerifyUser();
            int id = check.validateUser(user.Value, pwd.Value);
            if (id != 0) {
                Session["user"] = id; 
                Response.Redirect(FormsAuthentication.GetRedirectUrl(user.Value, false));
            }
            else
            {
                
                Response.Write("<script>alert('Incorrect Username or Password')</script>");
            }
        }
    }
}