using BlancoITELEC1C.Models;
using Microsoft.EntityFrameworkCore;

namespace BlancoITELEC1C.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        //Data Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    InstructorId = 1,
                    InstructorFirstName = "Gabriel",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2022-08-26"),
                    Rank = Rank.Instructor,
                    Email = "gab@gmail.com"
                },

                new Instructor()
                {
                    InstructorId = 2,
                    InstructorFirstName = "Gabriel",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2022-08-26"),
                    Rank = Rank.Professor,
                    Email = "gab@gmail.com"
                },

                new Instructor()
                {
                    InstructorId = 3,
                    InstructorFirstName = "Zyx",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2022-08-07"),
                    Rank = Rank.AssistantProfesor,
                    Email = "zyx@gmail.com"
                },

                new Instructor()
                {
                    InstructorId = 4,
                    InstructorFirstName = "Aerdriel",
                    InstructorLastName = "Montano",
                    InstructorIsTenured = true,
                    HiringDate = DateTime.Parse("2020-01-25"),
                    Rank = Rank.AssociateProfessor,
                    Email = "aedriel@gmail.com"
                });

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id= 1,
                    FirstName = "Gabriel",
                    LastName = "Montano", 
                    Course = Course.BSIT, 
                    AdmissionDate = DateTime.Parse("2022-08-26"), 
                    GPA = 1.5, 
                    Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,
                    FirstName = "Zyx",
                    LastName = "Montano", 
                    Course = Course.BSIS, 
                    AdmissionDate = DateTime.Parse("2022-08-07"), 
                    GPA = 1, 
                    Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,
                    FirstName = "Aerdriel",
                    LastName = "Montano", 
                    Course = Course.BSCS, 
                    AdmissionDate = DateTime.Parse("2020-01-25"), 
                    GPA = 1.5, 
                    Email = "aerdriel@gmail.com"
                });
        }
    }
}
