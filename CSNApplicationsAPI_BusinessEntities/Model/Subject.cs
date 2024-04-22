namespace DataAccess.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public required string SubjectName { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }
    }
}
