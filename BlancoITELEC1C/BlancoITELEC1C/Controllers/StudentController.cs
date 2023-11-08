using Microsoft.AspNetCore.Mvc;
using BlancoITELEC1C.Models;
using BlancoITELEC1C.Data;

namespace BlancoITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbData;

        public StudentController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

        public IActionResult Index()
        {
            return View(_dbData.Students);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            if (!ModelState.IsValid)
                return View();

            _dbData.Students.Add(newStudent);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChange)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == studentChange.Id);
            if(student != null)
            {
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;  
                student.Email = studentChange.Email;
                student.Course = studentChange.Course;
                student.GPA = studentChange.GPA;
                student.AdmissionDate = studentChange.AdmissionDate;
                _dbData.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student newStudent)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == newStudent.Id);
            
            if (student != null)
                _dbData.Students.Remove(student);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
