<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs"  Inherits="WebAppAsync.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
    <h1>Sync Products</h1>
    <form id="form1" runat="server">
    <div>
            <asp:GridView ID="ProductGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync.Models.Product"></asp:GridView>
        <br />
    </div>
    </form>
</body>
</html>
