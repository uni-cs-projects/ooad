<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addPoints.aspx.cs" Inherits="WebApplication6.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login-form">
        <form runat="server" id="form">
            <h2 class="text-center">Add Points</h2>
           
        <asp:dropdownlist class="custom-select custom-select-sm" id="dl" runat="server"></asp:dropdownlist>
         <p></p>
        <asp:DropDownList ID="DropDownList1" class="custom-select custom-select-sm" runat="server"></asp:DropDownList>
            <p></p>
        <asp:TextBox ID="TextBox1" placeholder="Enter Runs" class="form-control" required="required" runat="server"></asp:TextBox>
            <p></p>
        <asp:TextBox ID="TextBox2" placeholder="Enter Wickets" class="form-control" runat="server" required="required"></asp:TextBox>
            <p></p>
        <asp:TextBox ID="TextBox3" placeholder="Enter Sixes" class="form-control" runat="server" required="required"></asp:TextBox>
            <p></p>
        <asp:TextBox ID="TextBox4" placeholder="Enter Fours" class="form-control" runat="server" required="required"></asp:TextBox>
           <p></p>  
        <asp:button runat="server"  text="Add Points" class="btn btn-primary btn-lg" OnClick="Unnamed1_Click" />
                          
        </form>
              </div>
</asp:Content>
