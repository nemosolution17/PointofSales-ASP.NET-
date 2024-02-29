<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OurProducts.aspx.cs" Inherits="Salesapp.OurProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search By</title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            height: 121px;
            background-color: #33CC33;
        }
        .auto-style2 {
            background-color: #99FF99;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            margin-left: 317px;
        }
        </style>
</head>
<body style="height: 127px">
    <form id="form1" runat="server">
        <div class="auto-style7">
        <div class="auto-style1">
            <strong>
            <br />
            <span class="auto-style5">Products </span><span class="auto-style2"><span class="auto-style5">List</span></span></strong></div>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Search:  <asp:TextBox ID ="TxtSearch" runat="server"></asp:TextBox>
            <asp:Button ID ="ButSearch" runat="server" Text="Search" OnClick="Unnamed2_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server"  ShowHeaderwhenEmpty ="True"  EmptyDataText ="No Records Found!" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style8" Width="860px">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
           
        </asp:GridView>

            
        
        
    </form>
</body>
</html>
