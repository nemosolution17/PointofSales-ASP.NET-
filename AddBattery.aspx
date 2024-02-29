<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBattery.aspx.cs" Inherits="Salesapp.AddBattery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 72px;
            background-color: #66FF66;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 205px;
        }
        .auto-style4 {
            width: 205px;
            text-align: center;
        }
        .auto-style5 {
            color: #FF6600;
        }
        .auto-style6 {
            width: 495px;
        }
        .auto-style7 {
            height: 31px;
            width: 272px;
        }
        .auto-style8 {
            width: 205px;
            height: 31px;
        }
        .auto-style9 {
            width: 495px;
            height: 31px;
        }
        .auto-style10 {
            width: 272px;
        }
        .auto-style11 {
            font-size: large;
        }
        .auto-style12 {
            width: 272px;
            height: 41px;
        }
        .auto-style13 {
            width: 205px;
            height: 41px;
        }
        .auto-style14 {
            width: 495px;
            height: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <br />
            <span class="auto-style11">Add New Battery</span></strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style4"><strong>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Label"></asp:Label>
                    </strong></td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13">Battery Maker:</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="307px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">Battery Size:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" Height="31px" Width="210px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">Battery Terminal:</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" Width="211px">
                        <asp:ListItem>Normal</asp:ListItem>
                        <asp:ListItem>Abnormal</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">Battery Height:</td>
                <td class="auto-style9">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="27px" Width="211px">
                        <asp:ListItem>Flat</asp:ListItem>
                        <asp:ListItem>Tall</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">Battery Quantity</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server" Height="31px" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">Battery Price:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox5" runat="server" Height="32px" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">Battery Description</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox4" runat="server" Height="31px" Width="436px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="197px" />
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style4"><strong>
                    <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="Label"></asp:Label>
                    </strong></td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
