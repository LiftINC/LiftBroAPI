using LiftBroAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftBroApi.Contexts
{
    public class LiftBroSeedTwo
    {
        public LiftBroSeedTwo()
        {
            Activities = new List<Activity>() {
                new Activity() {Name = "Jump Squat"},
                new Activity() {Name="Squat"},
                new Activity() {Name = "Pushup"},
                new Activity() {Name = "Bench Press"},
                new Activity() {Name = "Deadlift"},
                new Activity() {Name = "Farmers walk"},
                new Activity() {Name = "Arnold Press"},
                new Activity() {Name =  "Situps"}
            };

            Exercises = new List<Exercise>()
            {
                new Exercise() {Activity = Activities[2], Repitations = 8, Sets = 3, Weight = 20},
                new Exercise() {Activity = Activities[3], Repitations = 8, Sets = 6, Weight = 20},
                new Exercise() {Activity = Activities[4], Repitations = 12, Sets = 3, Weight = 40},
                new Exercise() {Activity = Activities[5], Repitations = 8, Sets = 1, Weight = 20},
                new Exercise() {Activity = Activities[6], Repitations = 3, Sets = 3, Weight = 60},
                new Exercise() {Activity = Activities[1], Repitations = 8, Sets = 2, Weight = 20},
                new Exercise() {Activity = Activities[0], Repitations = 2, Sets = 5, Weight = 220},
                new Exercise() {Activity = Activities[0], Repitations = 2, Sets = 5, Weight = 220},

            };


            Workouts = new List<Workout>()
            {
                new Workout(){Exercises = new List<Exercise>() ,Name = "Workout1"},
                new Workout(){Exercises = new List<Exercise>(),Name = "Workout2"},
                new Workout(){Exercises = new List<Exercise>(),Name = "Workout4"},
                new Workout(){Exercises = new List<Exercise>(),Name = "Workout5"}
            };


            Users = new List<User>
            {
                new User() {Name = "Jostein", Password = "Jossa123", Workouts = new List<Workout>()},
                new User() {Name = "Einar", Password = "EinarRule5", Workouts = new List<Workout>()},
                new User() {Name = "Sondre", Password = "Sonny123", Workouts = new List<Workout>()},
                new User() {Name = "Peder", Password = "Peder", Workouts = new List<Workout>()}
            };
        }

        public  List<Activity> Activities { get; set; } 

        public  List<Exercise> Exercises { get; set; } 

        public  List<Workout> Workouts { get; set; } 

        public  List<User> Users { get; set; } 
    }
}
