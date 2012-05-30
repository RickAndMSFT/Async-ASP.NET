using System.Web.Mvc;
using System.Diagnostics;

namespace Mvc4Async.Filters
{
    public class UseStopwatchAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            filterContext.Controller.ViewData["stopWatch"] = stopWatch;
            filterContext.Controller.ViewBag.stopWatch = stopWatch;
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Stopwatch stopWatch = (Stopwatch)filterContext.Controller.ViewBag.stopWatch;
            stopWatch.Stop();

            double et = stopWatch.Elapsed.Seconds +
               (stopWatch.Elapsed.Milliseconds / 1000.0);

            filterContext.Controller.ViewBag.elapsedTime = // stopWatch.Elapsed + " --  " +
                 et.ToString();


        }

    }

}