using Election_System.DTO;
using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Models;
using Election_System.Repositories;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<StudentResponse> GetAll()
        {
            List<StudentResponse> studentResponses = new List<StudentResponse>();
            foreach (var student in _studentRepository.GetAll())
            {
                studentResponses.Add(new StudentResponse(student));
            }

            return studentResponses;
        }

        public StudentResponse GetById(int id)
        {
            return new StudentResponse(_studentRepository.GetById(id));
        }

    }

}
