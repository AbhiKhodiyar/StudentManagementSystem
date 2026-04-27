using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo) => _repo = repo;

        public Task<IEnumerable<Student>> GetAllStudents() => _repo.GetAllAsync();
        public Task<Student?> GetStudent(int id) => _repo.GetByIdAsync(id);
        public Task CreateStudent(Student student) => _repo.AddAsync(student);
        public Task UpdateStudent(Student student) => _repo.UpdateAsync(student);
        public Task RemoveStudent(int id) => _repo.DeleteAsync(id);
    }
}