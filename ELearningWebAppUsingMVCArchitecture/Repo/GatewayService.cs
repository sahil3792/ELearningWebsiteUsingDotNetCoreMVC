using ELearningWebAppUsingMVCArchitecture.Data;
using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
	public class GatewayService :GatewayRepo
	{
		private readonly ApplicationDbContext db;
		public GatewayService(ApplicationDbContext db)
		{
			this.db = db;
		}

		public IEnumerable<Course> DisplaySingleCourse(int id)
		{
			IEnumerable<Course> data = db.Courses.FromSqlRaw($"exec DisplaySingleCourse '{id}'").AsEnumerable();
			return data;
		}
	}
}
