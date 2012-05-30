using System;
using WebAppAsync.Service;

namespace WebAppAsync
{
    public partial class Gismos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var gizmoService = new GizmoService();
            GizmoGridView.DataSource = gizmoService.GetGizmos();
            GizmoGridView.DataBind();
        }
    }
}