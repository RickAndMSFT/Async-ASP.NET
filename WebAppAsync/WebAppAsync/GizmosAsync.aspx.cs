using System;
using System.Threading.Tasks;
using System.Web.UI;
using WebAppAsync.Service;

namespace WebAppAsync
{
    public partial class GizmosAsync : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(GetGizmosSvcAsync));
        }

        private async Task GetGizmosSvcAsync()
        {
            var gizmoService = new GizmoService();
            var gizmoList = await gizmoService.GetGizmosAsync();
            GizmosGridView.DataSource = gizmoList;
            GizmosGridView.DataBind();
        }
    }
}