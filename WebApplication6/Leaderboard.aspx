<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Leaderboard.aspx.cs" Inherits="WebApplication6.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 style="text-align: center;">Leaderboard</h1>
        <table class="table table-striped">
            <thead>
                <tr>
                    <th scope="col">Rank</th>
                    <th scope="col">Name</th>
                    <th scope="col">Points</th>
                </tr>
            </thead>
            <tbody id="result" runat="server">
                
               
            </tbody>
        </table>
    </div>
</asp:Content>
