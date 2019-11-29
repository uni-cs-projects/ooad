<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebApplication6.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="text-left">Your Leagues</h2>
        <h3 class="h33">Managing</h3>
        <form runat="server">
        <asp:Button ID="Button2" runat="server" Text="Create League" class="btn btn-primary btn-right" OnClick="Button2_Click" />
        <table class="table table-hover">
            <thead>
                <tr>
                    <th scope="col"></th>
                    <th scope="col">League Name</th>
                    <th scope="col">Tournament</th>
                    <th scope="col">Players</th>
                </tr>
            </thead>
            <tbody id="leagCreate" runat="server">
               
            </tbody>
        </table>
        <h3 class="h33">Participating</h3>
            
        
        <asp:Button ID="Button1" runat="server" Text="Join Leagues" class="btn btn-primary btn-right" OnClick="Button1_Click" /></form>
        <table class="table table-hover">
            <thead>
                <tr>
                    <th scope="col"></th>
                    <th scope="col">League Name</th>
                    <th scope="col">Tournament</th>
                    <th scope="col">Players</th>
                </tr>
            </thead>
            <tbody runat="server" id="leaguesP">
                
            </tbody>
        </table>
    </div>
</asp:Content>
