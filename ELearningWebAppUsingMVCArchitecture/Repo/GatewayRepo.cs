using ELearningWebAppUsingMVCArchitecture.Models;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
	public interface GatewayRepo
	{
		public IEnumerable<Course> DisplaySingleCourse(int id);

		public void AddOrder(string orderid, int courseid, double amount, string username);
	}
}
