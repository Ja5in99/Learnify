using System.Reflection;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Requirement> Requirements { get; set; }

        public DbSet<Learning> Learnings { get; set; }
        public DbSet<Basket> Basket {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // This is how you can write the configuration in this file (For Learning and Requirement table)

            // builder.Entity<Learning>()
            // .HasOne(U => U.Course)
            // .WithMany(a => a.Learnings)
            // .HasForeignKey(aa => aa.CourseId)
            // .OnDelete(DeleteBehavior.Cascade);

            // builder.Entity<Requirement>()
            // .HasOne(U => U.Course)
            // .WithMany(a => a.Requirements)
            // .HasForeignKey(aa => aa.CourseId)
            // .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}