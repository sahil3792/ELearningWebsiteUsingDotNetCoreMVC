using ELearningWebAppUsingMVCArchitecture.Models;
using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Mvc;

namespace ELearningWebAppUsingMVCArchitecture.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminRepo repo;

        public AdminController(AdminRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Welcome()
        {
            return View();
        }
        public IActionResult CategoriesSub()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoriesSub(Category cat) 
        {
            repo.AddCategory(cat);
            return Json("");
        }
        
        public IActionResult SubCategory(Category cat)
        {
            
            return View();
        }
        public IActionResult GetCategory(Category cat)
        {
            var data = repo.GetCategory(cat);
            return Json(data);
        }
    }
}
