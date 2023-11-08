using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace BlancoITELEC1C.Models
{
    public enum Rank
    {
        Instructor, Professor, AssistantProfesor, AssociateProfessor
    }
    public class Instructor
    {
        public int InstructorId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string InstructorFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage ="Please enter your Last Name")]
        public string InstructorLastName { get; set; }

        public bool InstructorIsTenured { get; set; }
 
        [Display(Name = "Academic Rank")]
        public Rank Rank { get; set; }

        [Display(Name = "Date Hired")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [RegularExpression("[0-9]{2}-[0-9]{3}-[0-9]{4}", ErrorMessage = "you must follow this format 00-000-0000")]
        [Display(Name = "Office Phone Number")]
        public string? Phone { get; set; }
    }
}
