<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LeaguesCreater.aspx.cs" Inherits="WebApplication6.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        LeagueName:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        StartDate:
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        EndDate:
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        Tournaments:
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    </form>
</asp:Content>
