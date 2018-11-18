using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftBroAPI.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace LiftBroApi.Reposetory.EFCore.SeedingData
{
    public static class LiftBroDBInitializer
    {
        public static LiftBroSeed LiftBroSeed { get; set; }

        public static void Seed(LiftBroContext context)
        {
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            var LiftSeed = new LiftBroSeed(context);

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            //LiftBroSeed = new LiftBroSeed();

            ////context.Database.EnsureDeleted();
            ////I'm bombing here
            ////LiftBroContext context = applicationBuilder.ApplicationServices.GetRequiredService<LiftBroContext>();


            ////SetupActivitys(context);
            ////SetupExercises(context);
            ////SetupWorkout(context);
            //if (!context.Users.Any())
            //{
            //    SetupUsers(context);
            //}
            
        }

        private static void SetupUsers(LiftBroContext context)
        {
            context.Users.AddRange(LiftBroSeed.Users);
            context.SaveChanges();
            
        }

        private static void SetupWorkout(LiftBroContext context)
        {
           context.Workouts.AddRange(LiftBroSeed.Workouts);
            context.SaveChanges();

        }

        private static void SetupExercises(LiftBroContext context)
        {
            context.Exercises.AddRange(LiftBroSeed.Exercises);
            context.SaveChanges();

        }

        public static void SetupActivitys(LiftBroContext context)
        {
            context.Activities.AddRange(LiftBroSeed.Activities);
            context.SaveChanges();
        }
    }
}