using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                
                Literal1.Text = @"<ul class=""navbar-nav navbar-right"">
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button""
                        data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <span class=""fa fa-user mr-sm-2"" id=""username""></span>"
                    +HttpContext.Current.User.Identity.Name+@"</a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        <a class=""dropdown-item"" href=""#"">Profile</a>
                        <a class=""dropdown-item"" href=""#"">Settings</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""logout.aspx"">Logout</a>
                    </div>
                </li>
            </ul>";
                Literal1.Visible = true;
              
            }
            else
            {
                frm1.Visible = true;
                
            }
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (email.Value == "shazad" && pwd.Value == "shazad")
            {
                FormsAuthentication.SetAuthCookie(email.Value, true);
                Response.Redirect(Request.Url.ToString());

                

            }
            else {
                Response.Write(@"<script>alert(""wrong credentials"")</script>");
              
            }
        }

    }
}