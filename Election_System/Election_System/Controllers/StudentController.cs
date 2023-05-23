using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("/students")]
        public List<StudentResponse> GetAll()
        {
            return _studentService.GetAll();
        }

        [HttpGet("/student/{id}")]
        public StudentResponse GetById(int id)
        {
            return _studentService.GetById(id);
        }

    }

}
