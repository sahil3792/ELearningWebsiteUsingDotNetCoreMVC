using ELearningWebAppUsingMVCArchitecture.Models;
using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Mvc;

namespace ELearningWebAppUsingMVCArchitecture.Controllers
{
	
	
	public class AuthController : Controller
	{
		private readonly AuthRepo repo;
		public AuthController(AuthRepo repo)
		{
			this.repo= repo;	
		}
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SignUp(User u)
		{
			repo.AddUser(u);
			return RedirectToAction("Index","Index");
		}

		public IActionResult SignIn()
		{
			return View();
		}
	}
}
