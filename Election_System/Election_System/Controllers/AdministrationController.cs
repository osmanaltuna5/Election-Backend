using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdministrationController : ControllerBase
    {

        private readonly IAdministrationService _administrationService;
        public AdministrationController(IAdministrationService administrationService)
        {
            _administrationService = administrationService;
        }

        [HttpGet("/administrations")]
        public List<AdministrationResponse> GetAll()
        {
            return _administrationService.GetAll();
        }

        [HttpGet("/administration/{id}")]
        public AdministrationResponse GetById(int id)
        {
            return _administrationService.GetById(id);
        }

    }
}
