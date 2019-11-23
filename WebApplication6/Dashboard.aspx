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
            <tbody>
                <tr class="click-row" data-href="#">
                    <th scope="row">1</th>
                    <td>My League1</td>
                    <td>Pakvistan vs Srilanka</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">2</th>
                    <td>My League2</td>
                    <td>India vs South Africa</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">3</th>
                    <td>My League3</td>
                    <td>Pakistan Super League</td>
                    <td>12345</td>
                </tr>
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
            <tbody>
                <tr class="click-row" data-href="#">
                    <th scope="row">1</th>
                    <td>Not My League1</td>
                    <td>Pakvistan vs Srilanka</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">2</th>
                    <td>Not My League2</td>
                    <td>India vs South Africa</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">3</th>
                    <td>Not My League3</td>
                    <td>Pakistan Super League</td>
                    <td>12345</td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
