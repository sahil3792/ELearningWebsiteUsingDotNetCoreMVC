using ELearningWebAppUsingMVCArchitecture.Data;
using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public class AdminService :AdminRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment env;
        public AdminService(ApplicationDbContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
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

        public void AddSubCategory(SubCategory scat)
        {
            db.Database.ExecuteSqlRaw($"exec AddSubCategory '{scat.SubCategoryName}','{scat.CategoryId}'");
        }

        public List<SubCategory> DisplaySubCategory(int id)
        {
            var data=db.SubCategories.FromSqlRaw($"exec DisplaySubCategory '{id}'").ToList();
            return data;
        }

        public void AddCourse(CourseViewModel cm)
        {
            var path = env.WebRootPath;
            var filePath = "Content/Images/" + cm.CourseImage.FileName;
            var fullPath = Path.Combine(path, filePath);
            UploadFile(cm.CourseImage, fullPath);
            //var obj = new Course()
            //{
            //    CourseImage = filePath,
            //    CourseName = cm.CourseName,
            //    CourseDescription = cm.CourseDescription,
            //    CourseTeacherName = cm.CourseTeacherName,
            //    CoursePrice = cm.CoursePrice,
            //    StudentCount = cm.StudentCount,
            //    CategoryId = cm.CategoryId,
            //    SubCategoryId = cm.SubCategoryId,
            //};
            db.Database.ExecuteSqlRaw($"exec InsertCourse '{filePath}','{cm.CourseName}','{cm.CourseDescription}','{cm.CourseTeacherName}','{cm.CoursePrice}','{cm.StudentCount}','{cm.CategoryId}','{cm.SubCategoryId}'");

        }

        public void UploadFile(IFormFile file, string fullPath)
        {
            FileStream stream = new FileStream(fullPath, FileMode.Create);
            file.CopyTo(stream);
        }
    }
}
