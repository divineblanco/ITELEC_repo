namespace BlancoITELEC1C.Models
{
    public enum Rank
    {
        Instructor, Professor, AssistantProfesor, AssociateProfessor
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public bool InstructorIsTenured { get; set; }
        public Rank Rank { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
