using System.ComponentModel.DataAnnotations;

namespace ELearningWebAppUsingMVCArchitecture.Models
{
    public class Course
    {
        [Key] 
        public int CourseId { get; set; }
        public string CourseImage { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseTeacherName { get; set; }

        public double CoursePrice { get; set; }
        public int StudentCount { get; set; }   
        public int CategoryId { get; set; } 
        public int SubCategoryId { get; set; }  


    }
}
