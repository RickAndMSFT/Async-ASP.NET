using System.Web;
using System.Web.Optimization;

namespace Mvc4Async
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            Assets.EnableOptimizations = !HttpContext.Current.IsDebuggingEnabled;

            var jsBundle = new JsBundle("~/bundles/js");
            jsBundle.Include("~/Scripts", "jquery-*");
            jsBundle.Include("~/Scripts", "jquery-ui*");
            jsBundle.Include("~/Scripts", "jquery.unobtrusive*");
            jsBundle.Include("~/Scripts", "jquery.validate*");
            jsBundle.Include("~/Scripts/AjaxLogin.js");
            bundles.Add(jsBundle);

            var mobileJsBundle = new JsBundle("~/bundles/mobileJs");
            mobileJsBundle.Include("~/Scripts", "jquery.mobile*");
            bundles.Add(mobileJsBundle);

            var cssBundle = new CssBundle("~/Content/css");
            cssBundle.Include("~/Content/site.css");
            bundles.Add(cssBundle);

            var mobileCssBundle = new CssBundle("~/Content/mobileCss");
            mobileCssBundle.Include("~/Content", "jquery.mobile*");
            bundles.Add(mobileCssBundle);

            var themePath = "~/Content/themes/base/";
            var themeBundle = new CssBundle(themePath + "css");
            themeBundle.Include(themePath + "jquery.ui.core.css");
            themeBundle.Include(themePath + "jquery.ui.resizable.css");
            themeBundle.Include(themePath + "jquery.ui.selectable.css");
            themeBundle.Include(themePath + "jquery.ui.accordion.css");
            themeBundle.Include(themePath + "jquery.ui.autocomplete.css");
            themeBundle.Include(themePath + "jquery.ui.button.css");
            themeBundle.Include(themePath + "jquery.ui.dialog.css");
            themeBundle.Include(themePath + "jquery.ui.slider.css");
            themeBundle.Include(themePath + "jquery.ui.tabs.css");
            themeBundle.Include(themePath + "jquery.ui.datepicker.css");
            themeBundle.Include(themePath + "jquery.ui.progressbar.css");
            themeBundle.Include(themePath + "jquery.ui.theme.css");
            bundles.Add(themeBundle);
        }
    }
}