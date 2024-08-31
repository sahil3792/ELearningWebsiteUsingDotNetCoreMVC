using ELearningWebAppUsingMVCArchitecture.Models;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public interface AdminRepo
    {
        void AddCategory(Category cat);

        List<Category> GetCategory(Category cat);

        void AddSubCategory(SubCategory scat);

        List<SubCategory> DisplaySubCategory(int id);

        List<Course> BindCourse(int id);

        void AddCourse(CourseViewModel cm);
        
        public void UploadFile(IFormFile file, string fullPath);
    }
}
