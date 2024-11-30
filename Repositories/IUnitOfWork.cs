namespace SchoolApp.Repositories
{
    public interface IUnitOfWork
    {
        TeacherRepository TeacherRepository { get; }
        StudentRepository StudentRepository { get; }
        CourseRepository CourseRepository { get; }
        UserRepository UserRepository { get; }

        Task<bool> SaveAsync();
    }
}
