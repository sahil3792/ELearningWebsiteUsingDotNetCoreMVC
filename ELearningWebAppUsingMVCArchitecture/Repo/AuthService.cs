using ELearningWebAppUsingMVCArchitecture.Data;
using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public class AuthService:AuthRepo
    {
        private readonly ApplicationDbContext db;
         public AuthService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddUser(User u)
        {
            u.Urole = "User";
            db.Database.ExecuteSqlRaw($"exec AddUser '{u.Username}','{u.Email}','{u.Password}','{u.Urole}'");

        }
    }
}
