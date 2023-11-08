using System.ComponentModel.DataAnnotations;

namespace BlancoITELEC1C.Models
{   public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Course")]
        public Course Course { get; set; }

        [RegularExpression("[1-5]{1}.[0-9]{1}", ErrorMessage = "you must follow this format 0.0")]
        [Display(Name = "GPA")]
        public double GPA { get; set; }

        [Display(Name = "Date Hired")]
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

    }
}
