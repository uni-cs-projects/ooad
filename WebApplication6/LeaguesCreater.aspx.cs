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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Request.Cookies["id"].Value);
            foreach (var item in new Tounaments().get())
            {
                DropDownList1.Items.Add(new ListItem(item.tourname,item.TourID.ToString()));
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            new LeaguesManager().createLeague(Convert.ToInt32(DropDownList1.SelectedValue), TextBox1.Text, Calendar1.SelectedDate, Calendar2.SelectedDate, Convert.ToInt32(Session["id"]));
            Response.Write("<script>alert('League Creation Successfull')</script>");
        }
    }
}