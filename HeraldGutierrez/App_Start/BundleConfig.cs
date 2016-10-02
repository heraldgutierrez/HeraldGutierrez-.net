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
                //.Include("~/Assets/Scripts/app.js")
                //.IncludeDirectory("~/Assets/Scripts/Controllers", "*.js")
                //.IncludeDirectory("~/Assets/Scripts/Directives", "*.js")
                //.IncludeDirectory("~/Assets/Scripts/Services", "*.js")
            );
        }
    }
}
