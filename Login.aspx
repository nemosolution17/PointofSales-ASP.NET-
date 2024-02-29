<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Salesapp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
            font-weight: 700;
            color: #000000;
            text-align: center;
            font-size: xx-large;
            background-color: #33CC33;
        }
        .auto-style2 {
            width: 88px;
        }
        .auto-style3 {
            width: 88px;
            text-align: center;
            height: 57px;
        }
        .auto-style4 {
            width: 452px;
        }
        .auto-style5 {
            color: #66FF33;
            background-color: #99FF99;
            width: 100%;
            height: 87px;
        }
        .auto-style6 {
            color: #CC3300;
        }
        .auto-style7 {
            width: 452px;
            height: 57px;
        }
        .auto-style8 {
            height: 57px;
        }
        .auto-style10 {
            color: #000099;
            font-size: large;
            text-align: center;
        }
    </style>
</head>
<body style="height: 604px">
    <form id="form1" runat="server">
        <div class="auto-style10">
            <strong>Owned By Layan Multipurpose Investment </strong>
        </div>
     
    
        <table class="auto-style5">
        <tr>
            <td class="auto-style1">
                Employee Login</td>
            
        </tr>
          

            
       
    
    </table>
        <table style="width: 100%; height: 199px;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">Username:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="33px" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">Password:</td>
                <td>
                    <asp:TextBox  ID="TextBox2" TextMode ="Password" runat="server" Height="38px"></asp:TextBox>
               
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style3"></td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style2"></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Incorrect Username or Password" CssClass="auto-style6"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
    </body>
</html>
