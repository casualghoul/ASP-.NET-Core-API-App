using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace IS_460_Assignment_4_Andrew_Horton.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
    }

    public class Student
    {
        [Key]
        [Required(ErrorMessage = "StudentID is required")]    
        public int StudentID { get; set; }

        
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(25, MinimumLength = 1)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }

    public class Course
    {
        [Key]
        [Required(ErrorMessage = "CourseID is required")]
        public int CourseID { get; set; }

        public string Title { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
