<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Manageteams.aspx.cs" Inherits="WebApplication6.WebForm6" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <form id="save-players" method="post" name='forms' action="Teamadder.aspx">

         <input type="submit" id="check" value="submit" class="btn btn-success btn-block login-btn"/>
           
        <input type="text" id="p0" runat="server" hidden="hidden"/>
        <input type="text" id="p1" runat="server" hidden="hidden"/>
        <input type="text" id="p2" runat="server" hidden="hidden"/>
        <input type="text" id="p3" runat="server" hidden="hidden"/>
        <input type="text" id="p4" runat="server" hidden="hidden"/>
        <input type="text" id="p5" runat="server" hidden="hidden"/>
        <input type="text" id="p6" runat="server" hidden="hidden"/>
        <input type="text" id="p7" runat="server" hidden="hidden"/>
        <input type="text" id="p8" runat="server" hidden="hidden"/>
        <input type="text" id="p9" runat="server" hidden="hidden"/>
        <input type="text" onchange="ab()" name="valid" id="p10" runat="server" hidden="hidden"/>
    </form>
    <form runat="server"  EnableViewState="true">
    <div class="container" style="display: inline-block;">
        <div class="row" style="padding-top: 10px;">
            <div class="col-md-1"></div>
            <table class="table table-hover col-md-4" id="select-players" style="padding-bottom:10px;">
                <thead class="thead-dark">
                    <tr>
                        <th scope="col" id="oko"></th>

                        <th scope="col">
                        
                     <asp:DropDownList ID="DropDownList2" runat="server" class="custom-select custom-select-sm"></asp:DropDownList>

                        </th>
                        <th scope="col">
                        
         <asp:DropDownList ID="DropDownList1" runat="server" ViewStateMode="Enabled" EnableViewState="true"  class="custom-select custom-select-sm" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="DropDownList1_TextChanged">

         </asp:DropDownList>
                    
                        </th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody id="teams" runat="server" onclick="ab()">
             
                </tbody>
            </table>
            <div class="col-md-1"></div>
            <table class="table table-hover col-md-4" id="my-team">
                <thead class="thead-dark">
                    <tr>
                        <th scope="col"></th>
                        <th scope="col">
                            <select class="custom-select custom-select-sm">
                                <option selected disabled>Your Team</option>
                            </select>
                        </th>
                        <th scope="col"></th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody onclick="ab2()">

                    

                </tbody>
            </table>
        </div>
    </div>
        </form>

    <script>
        var ok = 0;
        function ab() {
            
           
            ok++;
            if (ok > 11) {
                document.getElementById("check").disabled = false;
                if (ok >= 13) { ok = 12;}
            }
            else {
                document.getElementById("check").disabled = true;
            }
        }
        function ab2() {
            ok--;
            document.getElementById("check").disabled = true;
        }
        ab()
      
    </script>
    <p></p>
    <p></p>
    <p></p>
    <p></p>
    <p></p>
    <p></p>

</asp:Content>
