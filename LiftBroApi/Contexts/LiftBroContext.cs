using Microsoft.EntityFrameworkCore;

namespace LiftBroAPI.Entities
{
    public class LiftBroContext : DbContext
    {
        public LiftBroContext()
        {
                
        }
        public LiftBroContext(DbContextOptions<LiftBroContext> options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LiftBro.db");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Exercise> Exercises { get; set; }public DbSet<Workout> Blogs { get; set; }
    }
}