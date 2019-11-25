using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Control;

namespace WebApplication6
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AddUser a = new AddUser();
            if (a.adder(usrname.Value, pwd.Value, email.Value))
            {
                Response.Write("<script>alert('Registered Successfully')</script>");
                Response.Redirect("login.aspx");
            }
               else
	        {
                Response.Write("<script>alert('Email Already Exist')</script>");
            }
            
            
        }
    }
}