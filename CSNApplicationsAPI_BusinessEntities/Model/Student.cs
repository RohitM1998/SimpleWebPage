namespace DataAccess.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public required string StudentName { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }
    }
}
