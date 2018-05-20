<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Practice.aspx.cs" Inherits="Practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Button ID="loadProducts" runat="server" Text="load products" OnClick="loadProducts_Click" />
        <asp:Button ID="loadCustomerWithOrders" runat="server" Text="load customer with orders" OnClick="loadCustomerWithOrders_Click" />
         </div>
    </form>
</body>
</html>
