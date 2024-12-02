using Microsoft.AspNetCore.Mvc;

namespace uniqilo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
