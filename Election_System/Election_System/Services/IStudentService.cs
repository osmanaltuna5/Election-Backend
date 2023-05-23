using Election_System.DTO.Requests;
using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IStudentService
    {
        public List<StudentResponse> GetAll();
        public StudentResponse GetById(int id);

    }

}
