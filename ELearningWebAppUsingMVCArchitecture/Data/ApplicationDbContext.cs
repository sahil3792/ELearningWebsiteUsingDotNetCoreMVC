using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options): base(options) 
		{
			
		}

		public DbSet<User> Users { get; set; }
	}
}
