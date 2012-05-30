using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Net;

namespace Mvc4Async
{

    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
          
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Gizmos", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            // See http://blogs.msdn.com/b/tmarq/archive/2007/07/21/asp-net-thread-usage-on-iis-7-0-and-6-0.aspx
            /* 5.If your ASP.NET application is using web services (WFC or ASMX) or System.Net to communicate 
             * with a backend over HTTP you may need to increase connectionManagement/maxconnection.  
             * For ASP.NET applications, this is limited to 12 * #CPUs by the autoConfig feature.  
             * This means that on a quad-proc, you can have at most 12 * 4 = 48 concurrent 
             * connections to an IP end point.  Because this is tied to autoConfig, the easiest way
             * to increase maxconnection in an ASP.NET application is to 
             * set System.Net.ServicePointManager.DefaultConnectionLimit programatically,
             * from Application_Start, for example.  Set the value to the number of concurrent 
             * System.Net connections you expect your application to use.  I've set this to Int32.MaxValue
             * and not had any side effects, so you might try that--this is actually the default used 
             * in the native HTTP stack, WinHTTP.  If you're not able to set 
             * System.Net.ServicePointManager.DefaultConnectionLimit programmatically, you'll
             * need to disable autoConfig , but that means you also need to set maxWorkerThreads and maxIoThreads. 
             * You won't need to set minFreeThreads or minLocalRequestFreeThreads if you're not using classic/ISAPI mode.
             * */
            System.Net.ServicePointManager.DefaultConnectionLimit = int.MaxValue;
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}