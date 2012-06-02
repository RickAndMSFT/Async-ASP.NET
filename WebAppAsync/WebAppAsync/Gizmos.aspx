<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gizmos.aspx.cs" Inherits="WebAppAsync.Gismos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sync Gizmos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <asp:GridView ID="GizmoGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync.Models.Gizmo"></asp:GridView>
 
    </div>
        <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </form>
</body>
</html>
