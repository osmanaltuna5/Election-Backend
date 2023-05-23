using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class FileResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Content { get; set; }

        public FileResponse(Models.File file) 
        {
            Id = file.Id;
            Name = file.Name;
            Type = file.Type;
            Content = file.Content;
        }

    }

}
