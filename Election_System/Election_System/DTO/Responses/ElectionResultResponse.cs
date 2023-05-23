namespace Election_System.DTO.Responses
{
    public class ElectionResultResponse
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public int CandidateStudentId { get; set; }
        public StudentResponse Candidate { get; set; }
        public int NumberOfVotes { get; set; }

    }

}
