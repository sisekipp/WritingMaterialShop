using System.Web;
using System.Web.Optimization;

namespace WritingMaterialsShop
{
    public class BundleConfig
    {
        // Weitere Informationen zu Bundling finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=301862"
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery",
                "//code.jquery.com/jquery-1.11.3.min.js").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css", "~/Content/Admin.css"));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                        "~/Content/Admin.css"));
        }
    }
}
