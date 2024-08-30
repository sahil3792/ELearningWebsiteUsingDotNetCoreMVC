using ELearningWebAppUsingMVCArchitecture.Models;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public interface AdminRepo
    {
        void AddCategory(Category cat);

        List<Category> GetCategory(Category cat);
    }
}
