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
            <tbody id="leagues" runat="server">
                
               
            </tbody>
        </table>
 <form runat=server>
     <asp:Button ID="Button1" runat="server" Text="Show More" />
 </form>
    
    </div>
</asp:Content>
