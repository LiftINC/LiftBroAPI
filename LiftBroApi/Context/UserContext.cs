using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LiftBroApi.Entities;
 
 
 namespace LifeBroApi.Context
 {
 public class LiftBroApiContext : DbContext
    {
        public DbSet<LiftBroApi.Entities.User> Users { get; set; }
        public DbSet<LiftBroApi.Entities.Workout> Workouts { get; set; }
        public DbSet<LiftBroApi.Entities.Activity> Activities { get; set; }
        public DbSet<LiftBroApi.Entities.Exercise> Exercises { get; set; }
         public DbSet<LiftBroApi.Entities.Workout> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LiftBro.db");
        }
    }
    
}