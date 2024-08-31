using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Mvc;

namespace ELearningWebAppUsingMVCArchitecture.Controllers
{


	public class IndexController : Controller
	{
		private readonly UserRepo repo;
		public IndexController(UserRepo repo) {
			this.repo = repo;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}
		public IActionResult Courses()
		{
			var data = repo.FetchCourse();
			return View(data);
		}
		public IActionResult Blog()
		{
			return View();
		}
	}
}
