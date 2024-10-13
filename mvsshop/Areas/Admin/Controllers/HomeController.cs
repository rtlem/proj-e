using Microsoft.AspNetCore.Mvc;

namespace mvsshop.Areas.Admin.Controllers


{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
