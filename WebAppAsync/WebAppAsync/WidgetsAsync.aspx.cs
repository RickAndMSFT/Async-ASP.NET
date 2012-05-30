using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.UI;
using WebAppAsync.Service;

namespace WebAppAsync
{
    public partial class WidgetsAsync : System.Web.UI.Page
    {
        private Stopwatch stopWatch = new Stopwatch();

        protected void Page_Load(object sender, EventArgs e)
        {
            stopWatch.Start();
            RegisterAsyncTask(new PageAsyncTask(GetWidgetSrvAsync));
        }

        private async Task GetWidgetSrvAsync()
        {
            var widgetService = new WidgetService();
            var widgetList = await widgetService.GetWidgetsAsync();
            WidgetGridView.DataSource = widgetList;
            WidgetGridView.DataBind();

            stopWatch.Stop();
            ElapsedTimeLabel.Text = String.Format("Elapsed time: {0}", stopWatch.Elapsed.Milliseconds / 1000.0);
        }
    }
}