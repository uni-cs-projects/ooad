<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Leagues.aspx.cs" Inherits="WebApplication6.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 style="text-align: center;">Current Leagues</h1>
        <table class="table table-hover">
            <thead>
                <tr>
                    <th scope="col"></th>
                    <th scope="col">League Name</th>
                    <th scope="col">Players</th>
                </tr>
            </thead>
            <tbody>
                <tr class="click-row" data-href="#">
                    <th scope="row">1</th>
                    <td>Pakvistan vs Srilanka</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">2</th>
                    <td>India vs South Africa</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">3</th>
                    <td>T20 World Cup</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">4</th>
                    <td>Test World Cup</td>
                    <td>12345</td>
                </tr>
                <tr class="click-row" data-href="#">
                    <th scope="row">5</th>
                    <td>Pakistan Super League</td>
                    <td>12345</td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
