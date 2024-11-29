using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public interface ITeacherRepository
    {
        Task<List<Course>> GetTeacherCoursesAsync(int id);
        Task<Teacher> GetByPhoneNumberAsync(string phoneNumber);
        Task<List<User>> GetAllUsersTeachersAsync();
        Task<List<User>> GetAllUsersTeachersPaginatedAsync(int pageNumber, int pageSize);
        Task<User?> GetUserTeacherByUsernameAsync(string username);
    }
}
