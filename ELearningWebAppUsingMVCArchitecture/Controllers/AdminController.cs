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
    }
}
