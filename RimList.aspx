<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RimList.aspx.cs" Inherits="Salesapp.RimList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 85px;
            background-color: #66FF66;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            margin-left: 174px;
        }
    </style>
</head>
<body style="height: 84px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <br />
            <span class="auto-style2">Rim List</span><br class="auto-style2" />
            <br />
            </strong>
        </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style3" DataSourceID="SqlDataSource1" Width="925px">
            <Columns>
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="Hub" HeaderText="Hub" SortExpression="Hub" />
                <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                <asp:BoundField DataField="Peg" HeaderText="Peg" SortExpression="Peg" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="Price" HeaderText="Price" ReadOnly="True" SortExpression="Price" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Total_Amount" HeaderText="Total_Amount" ReadOnly="True" SortExpression="Total_Amount" />
            </Columns>
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SalesLayanConnectionString %>" SelectCommand="RimList" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <br />
    </form>
</body>
</html>
