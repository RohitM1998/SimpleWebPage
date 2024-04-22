namespace DataAccess.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public required string TeacherName { get; set; }
        public int ClassId { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        public virtual Class Class { get; set; }
    }
}
