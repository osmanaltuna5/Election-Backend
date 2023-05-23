using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IProcessService
    {
        public List<ProcessResponse> GetAllProcesses();

    }

}
