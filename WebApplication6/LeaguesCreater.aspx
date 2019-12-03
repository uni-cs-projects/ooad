<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LeaguesCreater.aspx.cs" Inherits="WebApplication6.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div>
            <h1>Enter League Information</h1><br>
            <form class="col-md-6" runat="server">
                <div class="form-group">
                    <label for="name">Name</label>
                    <input type="text" class="form-control" runat="server" id="leaguename" aria-describedby="emailHelp"
                        placeholder="Enter Name" required>
                </div>
                <div class="form-group">
                    <label for="startdate">Start Date</label>
                    <input type="date" class="form-control" runat="server" id="startdate" required>
                </div>
                <div class="form-group">
                    <label for="enddate">End Date</label>
                    <input type="date" class="form-control" runat="server" id="enddate" required>
                </div>
                <div class="form-group">
                <label for="labelforselecttournament">Tournament</label>
                 <asp:DropDownList ID="DropDownList2" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <asp:Button ID="Button2" runat="server" Text="submit" class="btn btn-primary" OnClick="Button1_Click" />
            </form>
        </div>
        <br><br><br>
    </div>

</asp:Content>
