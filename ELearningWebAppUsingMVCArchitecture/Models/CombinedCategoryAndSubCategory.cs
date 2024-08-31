namespace ELearningWebAppUsingMVCArchitecture.Models
{
    public class CombinedCategoryAndSubCategory
    {
        public ICollection<Category> Categories { get; set; } = new List<Category>();  // List of categories for the dropdown
        public SubCategory SubCategory { get; set; }
    }
}
