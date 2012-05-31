<%@ Page Async="true"  Language="C#" AutoEventWireup="true" CodeBehind="ProductsAsync.aspx.cs" Inherits="WebAppAsync.ProductsAsync" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products Asynchronous</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:GridView ID="ProductGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync.Models.Product"></asp:GridView>
   
    </div>
                <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </form>
</body>
</html>
