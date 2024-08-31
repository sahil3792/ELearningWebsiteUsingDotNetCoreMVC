using ELearningWebAppUsingMVCArchitecture.Models;
using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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

        public IActionResult DisplayAndGetSubCategory()
        {

            return View();

        }

        public IActionResult GetCategory(Category cat)
        {
            var data = repo.GetCategory(cat);
            return Json(data);
            //var viewModel = new CombinedCategoryAndSubCategory
            //{
            //    Categories = data,
            //    SubCategory = new SubCategory()
            //};
            //return View(viewModel);
        }

        [HttpPost]
        public IActionResult DisplayAndGetSubCategory(SubCategory scat)
        {
            repo.AddSubCategory(scat);
            return View();

        }


        public IActionResult Course()
        {
            return View();
        }

        public IActionResult BindSubCategory(int id)
        {
            var data = repo.DisplaySubCategory(id);
            return Json(data);
        }

        public IActionResult BindCourse(int id)
        {
            var data = repo.BindCourse(id);
            return Json(data); 
        }
    

        [HttpPost]
        public IActionResult Course(CourseViewModel cm)
        {
            repo.AddCourse(cm);
            return View();
        }

        public IActionResult AddVideo()
        {
           return View();
        }

        [HttpPost]
        public IActionResult StoreVideo(Video v)
        {
            repo.AddVideo(v);
            return Json("");
        }








    }
}
