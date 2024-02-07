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

        //IAction for Create Category using HttpPost attribute
        [HttpPost]
        public IActionResult Create(Category db)
        {
            _db.Categories.Add(db);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // IAction for Create Category default GET attribute 
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            var db = _db.Categories.Find(id);
            return View(db);
        }

        [HttpPost]
        public IActionResult Delete(Category db)
        {
            _db.Categories.Remove(db);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var db = _db.Categories.Find(id);
            return View(db);
        }

        [HttpPost]
        public IActionResult Edit(Category db)
        {
            _db.Categories.Update(db);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
