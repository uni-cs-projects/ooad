using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Form["usr"] != null && Request.Form["usr1"] != null)
            {
                VerifyUser check = new VerifyUser();
                int id = check.validateUser(Request.Form["usr"].ToString(), Request.Form["usr1"].ToString());
                if (id == 0)
                {
                    Response.Write("<script>alert('Incorrect Username or Password')</script>");
                }
                else
                {
                    Response.Redirect(Request.Url.ToString());
                }
            }
            
     

        }
    }
}