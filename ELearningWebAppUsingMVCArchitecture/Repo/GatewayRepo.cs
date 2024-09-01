using ELearningWebAppUsingMVCArchitecture.Models;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
	public interface GatewayRepo
	{
		public IEnumerable<Course> DisplaySingleCourse(int id);
	}
}
