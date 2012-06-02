<%@ Page Async="true"  Language="C#" AutoEventWireup="true" CodeBehind="GizmosAsync.aspx.cs" Inherits="WebAppAsync.GizmosAsync" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gizmos Async</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Gizmos Async</h1>
    <div>
        <asp:GridView ID="GizmosGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync.Models.Gizmo"></asp:GridView>
        <br />
           <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </div>
    </form>
</body>
</html>
