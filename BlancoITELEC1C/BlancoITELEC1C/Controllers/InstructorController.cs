using Microsoft.AspNetCore.Mvc;
using BlancoITELEC1C.Models;

namespace BlancoITELEC1C.Controllers
{

    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
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
        

        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(it => it.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }
    }
}
