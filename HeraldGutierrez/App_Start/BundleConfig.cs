using System.Web;
using System.Web.Optimization;

namespace HeraldGutierrez
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Assets/Bundles/Scripts")
                .Include("~/Assets/Scripts/Libs/angular.js")
                .Include("~/Assets/Scripts/Libs/angular-sanitize.js")
                .Include("~/Assets/Scripts/Libs/ui-select.js")
                .Include("~/Assets/Scripts/Libs/ui-mask.js")
                .Include("~/Assets/Scripts/Libs/jquery.min.js")
                .Include("~/Assets/Scripts/app.js")
                .IncludeDirectory("~/Assets/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Assets/Scripts/Directives", "*.js")
                .IncludeDirectory("~/Assets/Scripts/Services", "*.js")
            );

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
