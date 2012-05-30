<%@ Page Async="true"  Language="C#" AutoEventWireup="true" CodeBehind="WidgetsAsync.aspx.cs" Inherits="WebAppAsync.WidgetsAsync" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="WidgetGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync.Models.Widget"></asp:GridView>
        <br />
        <asp:Label ID="ElapsedTimeLabel" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
