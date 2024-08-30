using ELearningWebAppUsingMVCArchitecture.Data;
using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public class AdminService :AdminRepo
    {
        private readonly ApplicationDbContext db;
        public AdminService(ApplicationDbContext db)
        {
            this.db = db;   
        }
        public void AddCategory(Category cat)
        {
            db.Database.ExecuteSqlRaw($"exec InsertCategory '{cat.CategoryName}'");
        }

        public List<Category> GetCategory(Category cat)
        {
            var data = db.Categories.FromSqlRaw("exec GetCategory").ToList();
            return data;
        }
    }
}
