using System;
using BlancoITELEC1C.Models;
using BlancoITELEC1C.Services;

namespace BlancoITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }

        public List<Instructor> InstructorList { get; }

        public MyFakeDataService() 
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };

            InstructorList = new List<Instructor>()
            {

                new Instructor()
                {
                    InstructorId = 1,
                    InstructorFirstName = "Gabriel",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2022-08-26"),
                    Rank = Rank.Instructor
                },

                new Instructor()
                {
                    InstructorId = 2,
                    InstructorFirstName = "Gabriel",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2022-08-26"),
                    Rank = Rank.Professor
                },

                new Instructor()
                {
                    InstructorId = 3,
                    InstructorFirstName = "Zyx",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2022-08-07"),
                    Rank = Rank.AssistantProfesor
                },

                new Instructor()
                {
                    InstructorId = 4,
                    InstructorFirstName = "Aerdriel",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2020-01-25"),
                    Rank = Rank.AssociateProfessor
                },

            };
        }

    }
}
