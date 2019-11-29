using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using WebApplication6.Control;
using WebApplication6.Entity;

namespace WebApplication6
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["lid"] = Request.QueryString["lid"];
            SearchTeam a = new SearchTeam();
            
            foreach (var item in a.getTeams())
            {
                DropDownList1.Items.Add(new ListItem(item.TeamName, item.TeamID.ToString()));
              
            }
            foreach (var item in new Players().getPlayertype())
            {
                DropDownList2.Items.Add(new ListItem(item.TypeName, item.playerType.ToString()));

            }
            int i = 0;
            foreach (var item in new PlayersManager().getPlayer(Convert.ToInt32(DropDownList1.SelectedValue), 0))
            {
                teams.InnerHtml += @"<tr>
                        <th id=" + item.playerid + @">" + (i + 1) + @"</th>
                        <td colspan=""2"">
                            <span><img src = ""img/sangakkara.png"" alt="""" width=""40px"" height=""40px""></span>
                            <span class=""font-weight-bold"">" + item.playerName + @"</span>
                            <span class=""font-weight-lighter"" style=""font-size: smaller;"">rhb</span>
                        </td>
                        <td>
                            <span>
                                <i class=""fa fa-plus-square""></i>
                            </span>
                        </td>
                    </tr>";
                i++;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            teams.InnerHtml = "";
            int i = 0;
            foreach (var item in new PlayersManager().getPlayer(Convert.ToInt32(DropDownList1.SelectedValue), 0))
            {
                teams.InnerHtml += @"<tr>
                        <th id=" + item.playerid + @">" + (i + 1) + @"</th>
                        <td colspan=""2"">
                            <span><img src = ""img/sangakkara.png"" alt="""" width=""40px"" height=""40px""></span>
                            <span class=""font-weight-bold"">" + item.playerName + @"</span>
                            <span class=""font-weight-lighter"" style=""font-size: smaller;"">rhb</span>
                        </td>
                        <td>
                            <span>
                                <i class=""fa fa-plus-square""></i>
                            </span>
                        </td>
                    </tr>";
                i++;
            }
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            teams.InnerHtml = "";
            int i = 0;
            foreach (var item in new PlayersManager().getPlayer(Convert.ToInt32(DropDownList1.SelectedValue), 0))
            {
                teams.InnerHtml += @"<tr>
                        <th id=" + item.playerid + @">" + (i + 1) + @"</th>
                        <td colspan=""2"">
                            <span><img src = ""img/sangakkara.png"" alt="""" width=""40px"" height=""40px""></span>
                            <span class=""font-weight-bold"">" + item.playerName + @"</span>
                            <span class=""font-weight-lighter"" style=""font-size: smaller;"">rhb</span>
                        </td>
                        <td>
                            <span>
                                <i class=""fa fa-plus-square""></i>
                            </span>
                        </td>
                    </tr>";
                i++;
            }
        }
    }
}