using CoreWebApp_MVC_TempMaster.Models;

namespace CoreWebApp_MVC_TempMaster.Repository
{
    // Data Access Layer
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            // Veritabanından öğrenci listesini çekme işlemleri
        }

        public Student GetStudentById(int studentId)
        {
            // Veritabanından belirli bir öğrenciyi çekme işlemleri
        }

        public void AddStudent(Student student)
        {
            // Veritabanına öğrenci ekleme işlemleri
        }

        public void UpdateStudent(Student student)
        {
            // Veritabanındaki bir öğrenciyi güncelleme işlemleri
        }

        public void DeleteStudent(int studentId)
        {
            // Veritabanından bir öğrenciyi silme işlemleri
        }
    }
}
