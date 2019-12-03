<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Announce.aspx.cs" Inherits="WebApplication6.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h1 style="text-align: center;">Annoucements</h1>
            <div class="login-form">
        <form runat="server" id="form">
            <h2 class="text-center">Make Announcements</h2>
           
        <asp:dropdownlist class="custom-select custom-select-sm" id="dl" runat="server"></asp:dropdownlist>
         <p></p>        
        <asp:textbox id="tx" runat="server" class="form-control" placeholder="Enter Your Message" required="required"></asp:textbox>
           <p></p>  
        <asp:button runat="server" text="Make Announcements" class="btn btn-primary btn-lg" OnClick="Unnamed1_Click" />
                          
        </form>
              </div>
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
