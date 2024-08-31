using System.ComponentModel.DataAnnotations;

namespace ELearningWebAppUsingMVCArchitecture.Models
{
    public class Video
    {
        [Key]
        public int VideoId { get; set; } 
        public int CourseId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoLink { get; set; }
    }
}
