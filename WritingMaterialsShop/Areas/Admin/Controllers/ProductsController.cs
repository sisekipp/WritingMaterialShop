using System.Web.Mvc;

namespace WritingMaterialsShop.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Products
        public ActionResult Index()
        {
           return View();
        }

        public ActionResult Search(string query)
        {
            return PartialView("Results", null);
        }
    }
}