using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication6
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

               
           
            for (int i = 0; i < 15; i++)
            {
                teams.InnerHtml += @"<tr>
                        <th id="+i+@">"+(i+1)+@"</th>
                        <td colspan=""2"">
                            <span><img src = ""img/sangakkara.png"" alt="""" width=""40px"" height=""40px""></span>
                            <span class=""font-weight-bold"">Sangakkara</span>
                            <span class=""font-weight-lighter"" style=""font-size: smaller;"">rhb</span>
                        </td>
                        <td>
                            <span>
                                <i class=""fa fa-plus-square""></i>
                            </span>
                        </td>
                    </tr>";
            }
           

        }

    }
}