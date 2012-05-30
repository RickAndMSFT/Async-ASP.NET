using System;
using WebAppAsync.Service;

namespace WebAppAsync
{
    public partial class Widgets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var widgetService = new WidgetService();
            WidgetGridView.DataSource = widgetService.GetWidgets();
            WidgetGridView.DataBind();
        }
    }
}