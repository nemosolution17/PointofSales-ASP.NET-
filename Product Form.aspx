<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product Form.aspx.cs" Inherits="Salesapp.Product_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
            height: 100px;
            background-color: #00FF00;
        }
        .auto-style3 {
            width: 59%;
            margin-left: 316px;
        }
        .auto-style4 {
            width: 998px;
        }
        .auto-style5 {
            margin-left: 286px;
        }
        .auto-style6 {
            width: 998px;
            height: 39px;
        }
    </style>
</head>
<body style="height: 71px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <br />
            Products Form <br />
            </strong>
        </div>
        <p>
            &nbsp;</p>
        <table class="auto-style3">
            <tr>
                <td class="auto-style4">Product Name:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="553px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Product Category:</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cat_name" DataValueField="cat_name" Height="24px" Width="206px">
                        <asp:ListItem>Rims</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SalesLayanConnectionString %>" SelectCommand="SELECT [cat_name] FROM [Product_Category]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Product Model:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="616px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Quantity Available:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server" Height="31px" Width="269px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Product Unit Price:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server" Height="29px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Product Description:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox5" runat="server" Height="59px" Width="677px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="43px" OnClick="Button1_Click" Text="Submit" Width="130px" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
