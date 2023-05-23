using Election_System.Enumerations;
using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class ProcessResponse
    {
        public int Id { get; set; }
        public ProcessType Process { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ProcessResponse(Process process) { 
            Id = process.Id;
            Process = process.ProcessType;
            StartDate = process.StartDate;
            EndDate = process.EndDate;
        }

    }

}
