namespace DataAccess.Entities
{
    public class Class
    {
        public int ClassId { get; set; }
        public required string ClassName { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
