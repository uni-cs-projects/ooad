<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Manageteams.aspx.cs" Inherits="WebApplication6.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="display: inline-block;">
        <div class="row" style="padding-top: 10px;">
            <div class="col-md-1"></div>
            <table class="table table-hover col-md-4" id="select-players">
                <thead class="thead-dark">
                    <tr>
                        <th scope="col"></th>
                        <th scope="col">
                            <select class="custom-select custom-select-sm">
                                <option selected>Skills</option>
                                <option value="all">All</option>
                                <option value="batsmen">Batsmen</option>
                                <option value="bowler">Bowler</option>
                                <option value="allrounder">All Rounder</option>
                                <option value="wicketkeeper">Wicket Keeper</option>
                            </select>

                        </th>
                        <th scope="col">
                            <select class="custom-select custom-select-sm">
                                <option selected>Country</option>
                                <option value="all">All</option>
                                <option value="1">Pakistan</option>
                                <option value="2">Sirilanka</option>
                            </select>
                        </th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    <tr runat="server" id="tem3">
                        <th>1</th>
                        <td colspan="2">
                            <span class=""><img src="img/sangakkara.png" alt="" width="40px" height="40px"></span>
                            <span class="font-weight-bold">Sangakkara</span>
                            <span class="font-weight-lighter" style="font-size: smaller;">rhb</span>
                        </td>

                        <td>
                            <span>
                                <i class="fa fa-plus-square"></i>
                            </span>
                        </td>
                    </tr>
                    <tr runat="server" id="tem2">
                        <th>1</th>
                        <td colspan="2">
                            <span class=""><img src="img/sangakkara.png" alt="" width="40px" height="40px"></span>
                            <span class="font-weight-bold">Sangakkara</span>
                            <span class="font-weight-lighter" style="font-size: smaller;">rhb</span>
                        </td>
                        <td>
                            <span>
                                <i class="fa fa-plus-square"></i>
                            </span>
                        </td>
                    </tr>

                </tbody>
            </table>
            <div class="col-md-1"></div>
            <div id="oko" runat="server">
            <table class="table table-hover col-md-4" id="my-team">
                <thead class="thead-dark">
                    <tr>
                        <th scope="col"></th>
                        <th scope="col">
                            <select class="custom-select custom-select-sm">
                                <option selected disabled>Your Team</option>
                            </select>
                        </th>
                        <th scope="col"></th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody id="haha" runat="server">
                   
                    <tr runat="server" id="tem">
                        <th>1</th>
                        <td colspan="2">
                            <span class=""><img src="img/sangakkara.png" alt="" width="40px" height="40px"></span>
                            <span class="font-weight-bold">Kumar Sangakkara</span>
                            <span class="font-weight-lighter" style="font-size: smaller;">rhb</span>
                        </td>
                        <td>
                            <span>
                                <i class="fa fa-minus-square"></i>
                            </span>
                        </td>
                    </tr>

                    <tr runat="server" id="tem1" >
                        <th>1</th>
                        <td colspan="2" id="Td1" runat="server">
                            <span class=""><img src="img/sangakkara.png" alt="" width="40px" height="40px"></span>
                            <span  class="font-weight-bold">Kumar Sangakkara</span>
                            <span class="font-weight-lighter" style="font-size: smaller;">rhb</span>
                        </td>
                        <td>
                            <span>
                                <i class="fa fa-minus-square"></i>
                            </span>
                        </td>
                    </tr>
                

                </tbody>
            </table>
        </div>
    </div>

    </div>



</asp:Content>
