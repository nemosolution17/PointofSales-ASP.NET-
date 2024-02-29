<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchRims.aspx.cs" Inherits="Salesapp.SearchRims" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search By</title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            height: 100px;
            background-color: #75F06F;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            margin-left: 257px;
        }
        </style>
</head>
<body style="height: 127px">
    <form id="form1" runat="server">
        <div class="auto-style7">
        <div class="auto-style1">
            <strong>
            <br />
            <span class="auto-style5">Search For Rims Available</span></strong></div>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Search:  <asp:TextBox ID ="TxtSearch" runat="server"></asp:TextBox>
            <asp:Button ID ="ButSearch" runat="server" Text="Search" OnClick="Unnamed2_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server"  ShowHeaderwhenEmpty ="True"  EmptyDataText ="No Records Found!" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style8" Width="860px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
           
        </asp:GridView>

            
        
        
    </form>
</body>
</html>
