using CoreWebApp_MVC_TempMaster.Models;
using CoreWebApp_MVC_TempMaster.Repository;

namespace CoreWebApp_MVC_TempMaster.Service
{
    // Business Logic Layer
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            // İş mantığına uygun olarak öğrenci listesini alma işlemleri
        }

        public Student GetStudentById(int studentId)
        {
            // İş mantığına uygun olarak belirli bir öğrenciyi alma işlemleri
        }

        public void AddStudent(Student student)
        {
            // İş mantığına uygun olarak öğrenci ekleme işlemleri
        }

        public void UpdateStudent(Student student)
        {
            // İş mantığına uygun olarak bir öğrenciyi güncelleme işlemleri
        }

        public void DeleteStudent(int studentId)
        {
            // İş mantığına uygun olarak bir öğrenciyi silme işlemleri
        }
    }

}
