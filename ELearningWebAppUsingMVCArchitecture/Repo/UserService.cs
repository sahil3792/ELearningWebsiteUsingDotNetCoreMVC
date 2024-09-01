using ELearningWebAppUsingMVCArchitecture.Data;
using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
	public class UserService :UserRepo
	{
		private readonly ApplicationDbContext db;
		private readonly IWebHostEnvironment env;

		public UserService(ApplicationDbContext db,IWebHostEnvironment env)
		{
			this.db = db;	
			this.env = env;
		}
		public List<Course> FetchCourse()
		{
			var data = db.Courses.FromSqlRaw($"exec FetchCourses").ToList();
			return data;
		}

		public IQueryable<Course> DisplaySingleCourse(int id)
		{
			IQueryable<Course> data = db.Courses.FromSqlRaw($"exec DisplaySingleCourse '{id}'") ;
			return data;
		}
		public List<Course> FetchMyCourses(string username)
		{
			var data = db.Courses.FromSqlRaw($"exec FetchMyCourses '{username}'").ToList();
			return data;
		}

        public List<Video> GetVideosByCourseId(int courseid)
		{
			var data = db.Videos.FromSqlRaw($"exec GetVideoByCourseId '{courseid}'").ToList();
			return data;
		}

    }
}
