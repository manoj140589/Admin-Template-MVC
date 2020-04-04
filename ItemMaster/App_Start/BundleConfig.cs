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

            bundles.Add(new ScriptBundle("~/bundles/LoginJS").Include(
                        "~/Scripts/jsLogin.js"));

            bundles.Add(new StyleBundle("~/bundle/commoncss").Include(
                      "~/Assets/css/style.min.css"));
        }
    }
}
