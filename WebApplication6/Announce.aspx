<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Announce.aspx.cs" Inherits="WebApplication6.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h1 style="text-align: center;">Leaderboard</h1>
        <form runat="server" id="form">
        <asp:dropdownlist class="custom-select custom-select-sm" id="dl" runat="server"></asp:dropdownlist>
        <asp:textbox id="tx" runat="server"></asp:textbox>
        <asp:button runat="server" text="Make Announcements" class="btn btn-primary btn-lg" OnClick="Unnamed1_Click" />
        </form>
        <table class="table table-striped">

            <thead>
                <tr>
                    <th scope="col">Date</th>
                    <th scope="col">League</th>
                    <th scope="col">Message</th>
                </tr>
            </thead>
            <tbody id="msg" runat="server">
      
               
            </tbody>
        </table>
    </div>

</asp:Content>
