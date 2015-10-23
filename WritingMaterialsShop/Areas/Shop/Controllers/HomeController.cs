using System.Web.Mvc;

namespace WritingMaterialsShop.Areas.Shop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Shop/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}