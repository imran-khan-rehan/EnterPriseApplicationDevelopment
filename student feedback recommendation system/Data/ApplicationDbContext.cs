
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using student_feedback_recommendation_system.Data;
using student_feedback_recommendation_system.Models; // Make sure this is where your Student model is located

namespace student_feedback_recommendation_system.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

       public DbSet<Review> Reviews { get; set; }
        public DbSet<Student> Students { get; set; } // This should be plural if it represents a collection of Student entities
        public DbSet<Teacher> Teachers { get; set; }
      
        // If you have more entities, you would add them here
    }
}
namespace student_feedback_recommendation_system.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=imran;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}