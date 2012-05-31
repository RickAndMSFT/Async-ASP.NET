<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Widgets.aspx.cs" Inherits="WebAppAsync.Widgets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sync Widgets</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:GridView ID="WidgetGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync.Models.Widget"></asp:GridView>
        <br />
    
    </div>
                <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </form>
</body>
</html>
