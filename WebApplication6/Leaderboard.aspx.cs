﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "";
            foreach (string key in Request.Form.AllKeys)
            {
                a += Request.Form[key];
            }
            Response.Write(a);
        }
    }
}