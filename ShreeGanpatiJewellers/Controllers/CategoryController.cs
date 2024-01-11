using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ShreeGanpatiJewellers.Data;
using ShreeGanpatiJewellers.Models;

namespace ShreeGanpatiJewellers.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<Category> objCatagoryList = _db.Categories.ToList();
            return View(objCatagoryList);
        }
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj) 
        {
            if( obj.Name == obj.DisplayOrder.ToString()) 
            {
                ModelState.AddModelError("name", "The Display order can not be same");
            }
            if (ModelState.IsValid)
            { 
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
