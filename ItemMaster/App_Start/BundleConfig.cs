using System.Web;
using System.Web.Optimization;

namespace ItemMaster
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/commonjs").Include(
                        "~/Assets/libs/jquery/dist/jquery.min.js",
                        "~/Assets/libs/popper.js/dist/umd/popper.min.js",
                        "~/Assets/libs/bootstrap/dist/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/masterjs").Include(
                        "~/Assets/js/app.min.js",
                        "~/Assets/js/app.init.js",
                        "~/Assets/js/app-style-switcher.js",
                        "~/Assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js",
                        "~/Assets/extra-libs/sparkline/sparkline.js",
                        "~/Assets/js/waves.js",
                        "~/Assets/js/sidebarmenu.js",
                        "~/Assets/js/feather.min.js",
                        "~/Assets/js/custom.min.js",
                        "~/Assets/extra-libs/datatables.net/js/jquery.dataTables.min.js",
                        "~/Assets/extra-libs/datatables.net-bs4/js/dataTables.responsive.min.js"
                ));

          bundles.Add(new ScriptBundle("~/bundles/LoginJS").Include(
                        "~/Scripts/jsLogin.js"));

            bundles.Add(new StyleBundle("~/bundle/commoncss").Include(
                        "~/Assets/extra-libs/datatables.net-bs4/css/dataTables.bootstrap4.css",
                        "~/Assets/extra-libs/datatables.net-bs4/css/responsive.dataTables.min.css",
                        "~/Assets/css/style.min.css"));
        }
    }
}
