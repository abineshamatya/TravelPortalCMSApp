using System.Web;
using System.Web.Optimization;

namespace TravelPortalCMSApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/js/AdminJs")
                 .Include("~/js/AdminJs/app.min.js",
                 "~/js/AdminJs/AddPackages.js",
                  "~/js/AdminJs/EditImage.js",
                  "~/js/AdminJs/bootstrap-datepicker.js"
                  ));

            //bundles.Add(new ScriptBundle("~/js")
            //    .Include("~/js/jquery.js",
            //             "~/js/jquery-migrate-1.2.1.js",
            //             "~/js/script.js",
            //             "~/js/superfish.js",
            //             "~/js/jquery.ui.totop.js",
            //             "~/js/jquery.equalheights.js",
            //             "~/js/jquery.mobilemenu.js",
            //             "~/js/jquery.easing.1.3.js",
            //             "~/js/owl.carousel.js",
            //             "~/js/TMForm.js",
            //             "~/js/camera.js"
            //             ));

            //Use the development version of Modernizr to develop with and learn from. Then, when you're
            //ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"
                      ));

            //Admin Bundle Section
            bundles.Add(new StyleBundle("~/Content/AdminCss/css").Include(
                    "~/Content/AdminCss/bootstrap.min.css",
                     "~/Content/AdminCss/AdminLTE.min.css",
                     "~/Content/AdminCss/font-awesome.min.css",
                      "~/Content/AdminCss/datepicker3.css"
                     ));

            bundles.Add(new StyleBundle("~/Content/AdminCss/skins/css").Include(
                  "~/Content/AdminCss/skins/skin-blue.min.css"
                  ));

            //"~/Content/camera.css",
            //          "~/Content/form.css",
            //          "~/Content/owl.carousel.css",
            //          "~/Content/style.css"
        }
    }
}
