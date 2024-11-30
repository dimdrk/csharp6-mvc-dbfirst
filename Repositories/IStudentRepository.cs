using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Course>> GetSudentCoursesAsync(int id);
        Task<Student?> GetByAm(string? am);
        Task<List<User>> GetAllUsersStudentsAsync();
    }
}
