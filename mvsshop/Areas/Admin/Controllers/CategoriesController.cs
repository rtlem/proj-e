using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Mvc;

namespace mvsshop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext dbContext;

        public CategoriesController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IActionResult Index()
        {
          return View(); 
     
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            dbContext.Categories.Add(model);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
