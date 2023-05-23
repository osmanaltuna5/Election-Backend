using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAdministrationRepository _administrationRepository;
        private readonly IStudentRepository _studentRepository;
        public AuthService(IAdministrationRepository administrationRepository, IStudentRepository studentRepository)
        {
            _administrationRepository = administrationRepository;
            _studentRepository = studentRepository;
        }
        public LoginResponse Login(LoginRequest loginRequest)
        {

            foreach (var admin in _administrationRepository.GetAll())
            {
                if (admin.Username.Equals(loginRequest.Username) && admin.Password.Equals(loginRequest.Password))
                {
                    return new LoginResponse(admin.Id, admin.Role);
                }
            }

            foreach (var student in _studentRepository.GetAll())
            {
                if (student.Username.Equals(loginRequest.Username) && student.Password.Equals(loginRequest.Password))
                {
                    return new LoginResponse(student.Id, student.Role);
                }
            }

            return new LoginResponse(0, null);

        }

    }

}
