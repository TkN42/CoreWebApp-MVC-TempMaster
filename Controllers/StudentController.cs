using CoreWebApp_MVC_TempMaster.Models;
using CoreWebApp_MVC_TempMaster.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApp_MVC_TempMaster.Controllers
{
    // Presentation Layer (Controller)
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            // Tüm öğrencileri alma işlemleri
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            // Belirli bir öğrenciyi alma işlemleri
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            // Öğrenci ekleme işlemleri
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            // Belirli bir öğrenciyi güncelleme işlemleri
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            // Belirli bir öğrenciyi silme işlemleri
        }
    }
}
