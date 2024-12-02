using Microsoft.AspNetCore.Mvc;

namespace uniqilo.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
