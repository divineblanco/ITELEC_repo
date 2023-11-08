using Microsoft.AspNetCore.Mvc;
using BlancoITELEC1C.Models;
using BlancoITELEC1C.Data;

namespace BlancoITELEC1C.Controllers
{

    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbData;

        public InstructorController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

        public IActionResult Index()
        {
            return View(_dbData.Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(it => it.InstructorId == id);

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
            if(!ModelState.IsValid)
                return View();

            _dbData.Instructors.Add(newInstructor);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(it => it.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChange) 
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(it => it.InstructorId == instructorChange.InstructorId);

            if (instructor != null)
            {
                instructor.InstructorId = instructorChange.InstructorId;
                instructor.InstructorFirstName = instructorChange.InstructorFirstName;
                instructor.InstructorLastName = instructorChange.InstructorLastName;
                instructor.InstructorIsTenured = instructorChange.InstructorIsTenured;
                instructor.Rank = instructorChange.Rank;
                instructor.HiringDate = instructorChange.HiringDate;
                _dbData.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(it => it.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Student newInstructor)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(it => it.InstructorId == newInstructor.Id);

            if (instructor != null)
                _dbData.Instructors.Remove(instructor);
                _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
