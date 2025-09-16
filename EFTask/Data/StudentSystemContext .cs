using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;

namespace StudentSystem.Data
{
    internal class StudentSystemContext:DbContext
    {
    
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Resource> resources { get; set; }
        public DbSet<Homework> homeworks { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        

    }
}
