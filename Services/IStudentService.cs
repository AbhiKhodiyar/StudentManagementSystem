using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student?> GetStudent(int id);
        Task CreateStudent(Student student);
        Task UpdateStudent(Student student);
        Task RemoveStudent(int id);
    }
}