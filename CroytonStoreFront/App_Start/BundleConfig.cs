using System.Web;
using System.Web.Optimization;

namespace CroytonStoreFront
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region Default Bundles

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
            #endregion

            #region Croyton Store Front Bundles

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/js/jquery.min.js",
                  "~/Scripts/js/modernizr.js",
                  "~/Scripts/js/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/js/bootstrap.min.js",
                    "~/Scripts/js/jquery.magnific-popup.min.js",
                   "~/Scripts/js/owl.carousel.min.js",
                   "~/Scripts/js/jquery.waypoints.min.js",
                   "~/Scripts/js/jquery.counterup.min.js",
                   "~/Scripts/js/isotope.min.js",

                   "~/Scripts/revolution/js/jquery.themepunch.tools.min.js",
                   "~/Scripts/revolution/js/jquery.themepunch.revolution.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/revolution").Include(
                   "~/Scripts/revolution/js/extensions/revolution.extension.video.min.js",
                   "~/Scripts/revolution/js/extensions/revolution.extension.slideanims.min.js",
                   "~/Scripts/revolution/js/extensions/revolution.extension.actions.min.js",
                   "~/Scripts/revolution/js/extensions/revolution.extension.layeranimation.min.js",
                   "~/Scripts/revolution/js/extensions/revolution.extension.kenburn.min.js",
                   "~/Scripts/revolution/js/extensions/revolution.extension.navigation.min.js",

                   "~/Scripts/revolution/js/extensions/revolution.extension.migration.min.js",
                   "~/Scripts/revolution/js/extensions/revolution.extension.parallax.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/css/bootstrap.min.css",
                       "~/Content/css/owl.carousel.min.css",
                       "~/Content/css/owl.theme.default.min.css",
                       "~/Content/css/magnific-popup.css",
                       "~/Content/css/fonts.css",
                       "~/Content/css/flaticon.css",
                       "~/Content/revolution/css/settings.css",
                       "~/Content/css/style.css",
                       "~/Content/css/responsive.css",
                       "~/Content/css/fonts.css"));




            #endregion
        }
    }
}
