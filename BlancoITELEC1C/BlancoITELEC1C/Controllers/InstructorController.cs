using Microsoft.AspNetCore.Mvc;
using BlancoITELEC1C.Models;
using BlancoITELEC1C.Services;

namespace BlancoITELEC1C.Controllers
{

    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public InstructorController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {
            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(it => it.InstructorId == id);

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
            _dummyData.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(it => it.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChange) 
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(it => it.InstructorId == instructorChange.InstructorId);

            if (instructor != null)
            {
                instructor.InstructorId = instructorChange.InstructorId;
                instructor.InstructorFirstName = instructorChange.InstructorFirstName;
                instructor.InstructorLastName = instructorChange.InstructorLastName;
                instructor.InstructorIsTenured = instructorChange.InstructorIsTenured;
                instructor.Rank = instructorChange.Rank;
                instructor.HiringDate = instructorChange.HiringDate;
                
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(it => it.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Student newInstructor)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(it => it.InstructorId == newInstructor.Id);

            if (instructor != null)
                _dummyData.InstructorList.Remove(instructor);
            return RedirectToAction("Index");
        }
    }
}
