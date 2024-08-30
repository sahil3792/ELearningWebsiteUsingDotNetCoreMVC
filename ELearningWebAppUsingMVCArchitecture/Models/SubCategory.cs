using System.ComponentModel.DataAnnotations;

namespace ELearningWebAppUsingMVCArchitecture.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
