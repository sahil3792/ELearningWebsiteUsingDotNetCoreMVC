using ELearningWebAppUsingMVCArchitecture.Models;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
	public interface UserRepo
	{
		List<Course> FetchCourse();

		public IQueryable<Course> DisplaySingleCourse(int id);
		

		
	}
}
