using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppAsync.Service;

namespace WebAppAsync
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var widgetService = new WidgetService();

            var widgetList = widgetService.GetWidgets();
            // ToDo, display Widgets 
        }
    }
}