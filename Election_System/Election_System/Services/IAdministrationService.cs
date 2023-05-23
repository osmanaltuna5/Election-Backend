using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IAdministrationService
    {
        public List<AdministrationResponse> GetAll();
        public AdministrationResponse GetById(int id);

    }

}
