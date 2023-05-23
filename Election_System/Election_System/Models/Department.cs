namespace Election_System.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public List<Student>? Students { get; set; }

    }

}
