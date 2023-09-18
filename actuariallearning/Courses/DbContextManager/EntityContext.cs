using System;
using actuariallearning.Courses.Models;
using Microsoft.EntityFrameworkCore;



namespace actuariallearning.Courses.DbContextManager
{
    public class CourseContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Student> Student { get; set; }

        public CourseContext(DbContextOptions<CourseContext> options): base(options)
        {
        }
    }
}
