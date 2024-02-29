<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRims.aspx.cs" Inherits="Salesapp.AddRims" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 73px;
            background-color: #00FF00;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            width: 77%;
            margin-left: 128px;
        }
        .auto-style4 {
            width: 253px;
        }
        .auto-style5 {
            width: 111px;
        }
        .auto-style6 {
            width: 195px;
        }
        .auto-style7 {
            width: 253px;
            text-align: left;
        }
        .auto-style8 {
            width: 253px;
            text-align: center;
        }
        .auto-style9 {
            color: #FF6600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <br />
            <span class="auto-style2">Add Rims</span></strong></div>
        <p>
            &nbsp;</p>
        <table class="auto-style3">
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style8">
                    <strong>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Text="Label"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">Rim Type:</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Rim_type" DataValueField="Rim_type" Height="21px" Width="185px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">Rim Size</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Width="198px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">Cars Used:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" Width="495px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">Quantity:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server" Height="28px" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">Price:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">Description:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox5" runat="server" Width="525px"></asp:TextBox>
                </td>
            </tr>
            

            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="166px" Height="31px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style8"><strong>
                    <asp:Label ID="Label2" runat="server" CssClass="auto-style9" Text="Label"></asp:Label>
                    </strong></td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SalesLayanConnectionString %>" SelectCommand="SELECT * FROM [Rims]"></asp:SqlDataSource>
    </form>
</body>
</html>
