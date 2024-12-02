using AutoMapper;
using SchoolApp.Data;
using SchoolApp.DTO;
using SchoolApp.Repositories;

namespace SchoolApp.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<TeacherService> _logger;

        public TeacherService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TeacherService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public Task<List<UserLoginDTO>> GetAllUsersTeachersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserLoginDTO>> GetAllUsersTeachersAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetTeacherByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTeacherCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task SignUpUserAsync(TeacherSignupDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
