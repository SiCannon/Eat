using System.Web.Optimization;
using BundleTransformer.Core.Bundles;

namespace Eat.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/ang").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-route.js",
                        "~/Scripts/angular-resource.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/eat").Include(
                        "~/Js/Modules/app.js",
                        "~/Js/Services/PagingInfo.js",
                        "~/Js/Services/PagingTracker.js",
                        "~/Js/Services/FoodService.js",
                        "~/Js/Controllers/NavbarCtrl.js",
                        "~/Js/Controllers/FoodListCtrl.js",
                        "~/Js/Controllers/FoodDetailCtrl.js"
                        ));

            bundles.Add(new CustomStyleBundle("~/Content/less").Include(
                        "~/Content/bootstrap/less/bootstrap.less",
                        "~/Content/font-awesome/less/font-awesome.less",
                        "~/Content/site.less"
                        ));
        }
    }
}