using Election_System.DTO.Responses;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class ProcessService : IProcessService
    {
        private readonly IProcessRepository _processRepository;

        public ProcessService(IProcessRepository processRepository)
        {
            _processRepository = processRepository;
        }

        public List<ProcessResponse> GetAllProcesses()
        {
            List<ProcessResponse> processResponses = new List<ProcessResponse>();
            foreach(var process in _processRepository.GetAll())
            {
                processResponses.Add(new ProcessResponse(process));
            }

            return processResponses;
        }

    }
}
