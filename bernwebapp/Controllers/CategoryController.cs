using bernwebapp.Data;
using bernwebapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace bernwebapp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        //IAction for Create Category
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}
