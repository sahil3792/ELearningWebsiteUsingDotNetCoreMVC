
using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Authorization;
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

		public IActionResult ViewCourse(int id)
		{
			var data = repo.DisplaySingleCourse(id);
			return View(data);
		}
		[Authorize]
		public IActionResult MyCourses()
		{
			string username = HttpContext.Session.GetString("User");
			var data = repo.FetchMyCourses(username);
			return View(data);
		}

		public IActionResult ViewMyCourse(int courseid)
		{
			var data = repo.GetVideosByCourseId(courseid);
			return View(data);
		}
	}
}
