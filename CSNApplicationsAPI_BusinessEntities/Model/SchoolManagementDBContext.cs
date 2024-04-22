using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities
{
    public class SchoolManagementDBContext : DbContext
    {
        public SchoolManagementDBContext()
        {

        }

        public SchoolManagementDBContext(DbContextOptions options)
            : base(options) 
        {
            
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SchoolManagement;user id=TpsAdmin;password=@dminPa$$word;Encrypt=false;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentId, e.SubjectId });

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Subject)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.SubjectId);

            modelBuilder.Entity<Class>()
                .HasOne(e => e.Teacher)
                .WithOne(t => t.Class)
                .HasForeignKey<Teacher>(t => t.ClassId);

            modelBuilder.Entity<Course>()
                .HasNoKey();
        }
    }
}
