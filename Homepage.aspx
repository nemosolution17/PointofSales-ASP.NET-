<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Salesapp.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 97px;
            background-color: #66FF66;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            width: 490px;
        }
        .auto-style5 {
            width: 99%;
        }
        .auto-style6 {
            width: 181px;
        }
        .auto-style7 {
            margin-left: 109px;
            margin-top: 53px;
        }
        .auto-style8 {
            margin-left: 111px;
        }
        .auto-style12 {
            margin-left: 110px;
            margin-top: 61px;
        }
    </style>
</head>
<body style="height: 87px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br class="auto-style2" />
            <span class="auto-style2">Homepage</span></div>
        <table class="auto-style5">


           
         
            
            
            <tr>
                <td class="auto-style6">
                    <br />
                    <br />
                </td>
              
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style12" Height="90px" OnClick="Button1_Click" Text="Search for Rims" Width="306px" /><br />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style7" Height="90px" Text="Search for Battery" Width="306px" OnClick="Button2_Click1" />
                </td>
            </tr>

            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style8" Height="90px" Text="Input Rim Sale" Width="306px" OnClick="Button3_Click" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style8" Height="90px" Text="Input Battery Sale" Width="306px" OnClick="Button4_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button5" runat="server" CssClass="auto-style8" Height="92px" Text="Add Rims" Width="306px" OnClick="Button5_Click" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" CssClass="auto-style8" Height="90px" Text="Add Battery" Width="306px" OnClick="Button6_Click" />
                </td>
            </tr>

        

            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button7" runat="server" CssClass="auto-style8" Height="91px" Text="Return Rim" Width="306px" OnClick="Button7_Click" />
                </td>
                <td>
                    <asp:Button ID="Button8" runat="server" CssClass="auto-style8" Height="90px" Text="Return Battery" Width="306px" OnClick="Button8_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button9" runat="server" CssClass="auto-style8" Height="91px" Text="Add Customer" Width="306px" OnClick="Button9_Click" />
                </td>
                <td>
                    <asp:Button ID="Button10" runat="server" CssClass="auto-style8" Height="90px" Text="View Sales" Width="306px" OnClick="Button10_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button11" runat="server" CssClass="auto-style8" Height="91px" Text="View Rim List Available" Width="306px" OnClick="Button11_Click" />
                </td>
                <td>
                    <asp:Button ID="Button12" runat="server" CssClass="auto-style8" Height="91px" Text="View Battery List Available" Width="306px" OnClick="Button12_Click" />
                </td>
            </tr>

        

            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button13" runat="server" CssClass="auto-style8" Height="91px" Text="View Rim Sales Record" Width="306px" OnClick="Button13_Click" />
                </td>
                <td>
                    <asp:Button ID="Button14" runat="server" CssClass="auto-style8" Height="91px" Text="View Battery Sales Record" Width="306px" OnClick="Button14_Click" />
                </td>
            </tr>

        

        </table>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
