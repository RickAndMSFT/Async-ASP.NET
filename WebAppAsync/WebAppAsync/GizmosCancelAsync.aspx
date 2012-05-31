<%@ Page  Async="true"  AsyncTimeout="1" Language="C#" AutoEventWireup="true" CodeBehind="GizmosCancelAsync.aspx.cs" Inherits="WebAppAsync.GizmosCancelAsync" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:GridView ID="GizmosGridView" runat="server" AutoGenerateColumns="true" ItemType="WebAppAsync.Models.Gizmos"></asp:GridView>
        <br />
          </div>
                <br />
        <a id="A1" runat="server" href="~/">Home</a>
    </form>
</body>
</html>
