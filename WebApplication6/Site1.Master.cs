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
             
              
            }
            else
            {
                Literal1.Text = @"<form id=""frm1"" class=""form-inline""  method=""post"" name=""frms"" action=""Default.aspx"" visible=""false"">
    <input id=""email"" class=""form-control mr-sm-2 my-1 form-control-sm"" name=""usr"" type=""text"" placeholder=""Email""/>
                <input id=""pwd"" name=""usr1"" class=""form-control mr-sm-2 my-1 form-control-sm"" type=""password"" placeholder=""Password""/>
                <input class=""btn btn-outline-light my-2 my-sm-0 btn-sm"" type=""submit"" value=""Log In"" /> &nbsp;
                <a href = ""register.aspx"" class=""btn btn-outline-light my-2 my-sm-0 btn-sm"" role=""button"">Register</a>
                </form>";
                
            }
           
            
        }

  

    }
}