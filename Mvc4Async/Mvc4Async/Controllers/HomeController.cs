using System;
using System.Web.Mvc;
using Mvc4Async.Models;
using System.Threading.Tasks;
using Mvc4Async.Filters;
using System.Web.UI;
using System.Threading;
using Mvc4Async.Service;

namespace Mvc4Async.Controllers
{
    [UseStopwatch]
    [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
    public class HomeController : Controller
    {
        public async Task<ActionResult> PWGasync()
        {
            ViewBag.SyncType = "Asynchronous";
            var widgetService = new WidgetService();
            var prodService = new ProductService();
            var gizmoService = new GizmoService();

            var widgetTask = widgetService.GetWidgetsAsync();
            var prodTask = prodService.GetProductsAsync();
            var gizmoTask = gizmoService.GetGizmosAsync();

            await Task.WhenAll(widgetTask, prodTask, gizmoTask);

            var pwgVM = new ProdGizWidgetVM(
               widgetTask.Result,
               prodTask.Result,
               gizmoTask.Result
               );

            return View("PWG", pwgVM);
        }

        [AsyncTimeout(50)]
        [HandleError(ExceptionType = typeof(TimeoutException), View = "TimeoutError")]
        public async Task<ActionResult> PWGtimeOut(CancellationToken cancellationToken)
        {
            ViewBag.SyncType = "Asynchronous with CancellationToken";

            var widgetService = new WidgetService();
            var prodService = new ProductService();
            var gizmoService = new GizmoService();

            var widgetTask = widgetService.GetWidgetsAsync(cancellationToken);
            var prodTask = prodService.GetProductsAsync(cancellationToken);
            var gizmoTask = gizmoService.GetGizmosAsync(cancellationToken);

            await Task.WhenAll(widgetTask, prodTask, gizmoTask);

            var pwgVM = new ProdGizWidgetVM(
               widgetTask.Result,
               prodTask.Result,
               gizmoTask.Result
               );

            return View("PWG", pwgVM);
        }

        public ActionResult PWG()
        {
            ViewBag.SyncType = "Synchronous";
            var widgetService = new WidgetService();
            var prodService = new ProductService();
            var gizmoService = new GizmoService();

            var pwgVM = new ProdGizWidgetVM(
                widgetService.GetWidgets(),
                prodService.GetProducts(),
                gizmoService.GetGizmos()
               );

            return View("PWG", pwgVM);
        }

        public async Task<ActionResult> WidgetsAsync()
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            var widgetService = new WidgetService();
            return View("Widgets", await widgetService.GetWidgetsAsync());
        }

        public ActionResult Widgets()
        {
            ViewBag.SyncOrAsync = "Synchronous";
            var widgetService = new WidgetService();

            return View("Widgets", widgetService.GetWidgets());
        }

        [AsyncTimeout(150)]
        [HandleError(ExceptionType = typeof(TimeoutException),
                                            View = "TimeoutError")]
        public async Task<ActionResult> GizmosCancelAsync(
                               CancellationToken cancellationToken)
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            var gizmoService = new GizmoService();
            return View("Gizmos",
                await gizmoService.GetGizmosAsync(cancellationToken));
        }

        public async Task<ActionResult> GizmosAsync()
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            var gizmoService = new GizmoService();
            return View("Gizmos", await gizmoService.GetGizmosAsync());
        }

        public ActionResult Gizmos()
        {
            ViewBag.SyncOrAsync = "Synchronous";
            var gizmoService = new GizmoService();
            return View("Gizmos", gizmoService.GetGizmos());
        }

        public async Task<ActionResult> ProductsAsync()
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            var productsService = new ProductService();
            return View("Products", await productsService.GetProductsAsync());
        }

        public ActionResult Products()
        {
            ViewBag.SyncOrAsync = "Synchronous";
            var prodService = new ProductService();
            return View("Products", prodService.GetProducts());
        }


    } // End of HomeController
       

}

