<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Salesapp.ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:GridView ID ="prodlist" runat="server">
                <Columns>
                    <asp:BoundField DataField ="prod_id" HeaderText ="ID" />
                    <asp:BoundField DataField ="prod_name" HeaderText ="Products" />
                    <asp:BoundField DataField ="prod_model" HeaderText ="Models" />
                    <asp:BoundField DataField ="prod_description" HeaderText ="Descriptions" />
                    <asp:BoundField DataField ="cat_id" HeaderText ="Cat ID" />
                    <asp:BoundField DataField ="prod_quantity" HeaderText ="Quantity" />  
                    <asp:BoundField DataField ="prod_unit_cost_price" HeaderText ="Price" />

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
