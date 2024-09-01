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
		public DbSet<Category> Categories { get; set; }

		public DbSet<SubCategory> SubCategories { get; set; }

		public DbSet<Course> Courses { get; set; }

		public DbSet<Video> Videos { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
