using LiftBroAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftBroApi.Reposetory.EFCore.SeedingData
{
    public class LiftBroSeed
    {
        public LiftBroSeed(LiftBroContext context)
        {
            

            //User user = new User()
            //{
            //    Name = "Sondre", Password = "SondreRule",
            //    ID = 1,Workouts = new List<Workout>()
            //    {
            //        new Workout(){
            //            Name = "Workout 1",
            //            ID = 1,
            //            Exercises = new List<Exercise>(){
            //                new Exercise()
            //                {
            //                    ID = 1,Repitations = 8,Sets = 3,Weight = 50,Activity = new Activity() { ID = 1,Name = "Bench press"}
            //                },
            //                new Exercise()
            //                {
            //                    ID = 2,Repitations = 8,Sets = 3,Weight = 50,Activity = new Activity() { ID = 2,Name = "Pushups"}
                            
            //                },
            //                new Exercise()
            //                {
            //                    ID = 3,Repitations = 8,Sets = 3,Weight = 50,Activity = new Activity() { ID = 3,Name = "Squat"}

            //                }

            //            }
            //        },
            //        new Workout(){
            //            Name = "Workout 2",
            //            ID = 2,
            //            Exercises = new List<Exercise>(){
            //                new Exercise()
            //                {
            //                    ID = 4,Repitations = 8,Sets = 3,Weight = 50,Activity = new Activity() { ID = 4,Name = "Military press"}
            //                },
            //                new Exercise()
            //                {
            //                    ID = 5,Repitations = 8,Sets = 3,Weight = 50,Activity = new Activity() { ID = 5,Name = "Farmers Walk"}

            //                },
            //                new Exercise()
            //                {
            //                    ID = 6,Repitations = 8,Sets = 3,Weight = 50,Activity = new Activity() { ID = 6,Name = "Skiing"}

            //                }

            //            }
            //        }
            //    }
            //};
            //context.Users.Add(user);
            //context.SaveChanges();


            Activities = new List<Activity>() {
                new Activity() {ID = 1, Name = "Jump Squat"},
                new Activity() {ID = 2, Name = "Squat"},
                new Activity() {ID = 3, Name = "Pushup"},
                new Activity() {ID = 4, Name = "Bench Press"},
                new Activity() {ID = 5, Name = "Deadlift"},
                new Activity() {ID = 6, Name = "Farmers walk"},
                new Activity() {ID = 7, Name = "Arnold Press"},
                new Activity() {ID = 8, Name =  "Situps"}
            };

            context.Activities.AddRange(Activities);
            context.SaveChanges();

            Exercises = new List<Exercise>()
            {
                new Exercise() {ID =  1,Repitations = 8, Sets = 3, Weight = 20},
                new Exercise() {ID =  2,Repitations = 8, Sets = 6, Weight = 20},
                new Exercise() {ID =  3,Repitations = 12, Sets = 3, Weight = 40},
                new Exercise() {ID =  4,Repitations = 8, Sets = 1, Weight = 20},
                new Exercise() {ID =  5,Repitations = 3, Sets = 3, Weight = 60},
                new Exercise() {ID =  6,Repitations = 8, Sets = 2, Weight = 20},
                new Exercise() {ID =  7,Repitations = 2, Sets = 5, Weight = 220},
                new Exercise() {ID =  8,Repitations = 2, Sets = 5, Weight = 220},

            };

            context.AddRange(Exercises);
            context.SaveChanges();

            var Ex0 = context.Exercises.FirstOrDefault(x => x.ID == 1);
            Ex0.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 2);
            var Ex1 = context.Exercises.FirstOrDefault(x => x.ID == 2);
            Ex1.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 3);
            var Ex2 = context.Exercises.FirstOrDefault(x => x.ID == 2);
            Ex2.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 4);
            var Ex3 = context.Exercises.FirstOrDefault(x => x.ID == 3);
            Ex3.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 5);
            var Ex4 = context.Exercises.FirstOrDefault(x => x.ID == 4);
            Ex4.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 6);
            var Ex5 = context.Exercises.FirstOrDefault(x => x.ID == 5);
            Ex5.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 1);
            var Ex6 = context.Exercises.FirstOrDefault(x => x.ID == 6);
            Ex6.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 1);
            var Ex7 = context.Exercises.First(x => x.ID == 7);
            Ex7.Activity =
            context.Activities.FirstOrDefault((x) => x.ID == 3);


            context.Exercises.Update(Ex0);
            context.Exercises.Update(Ex1);
            context.Exercises.Update(Ex2);
            context.Exercises.Update(Ex3);
            context.Exercises.Update(Ex4);
            context.Exercises.Update(Ex5);
            context.Exercises.Update(Ex6);
            context.Exercises.Update(Ex7);
            context.SaveChanges();

            Workouts = new List<Workout>()
            {
                new Workout(){Exercises = context.Exercises.Where((x) =>x.ID ==1 || x.ID ==2 || x.ID == 4 || x.ID == 6).ToList(),Name = "Workout1"},
                new Workout(){Exercises = context.Exercises.Where((x) =>x.ID ==1 || x.ID ==2 || x.ID == 5 || x.ID == 7).ToList(),Name = "Workout2"},
                new Workout(){Exercises = context.Exercises.Where((x) =>x.ID ==1 || x.ID ==4 || x.ID == 5).ToList(),Name = "Workout4"},
                new Workout(){Exercises = context.Exercises.Where((x) =>x.ID ==7 || x.ID ==4 || x.ID == 1 || x.ID == 4).ToList(),Name = "Workout5"}
            };
            context.Workouts.AddRange(Workouts);
            context.SaveChanges();

            Users = new List<User>
            {
                new User() {Name = "Jostein", Password = "Jossa123", Workouts = context.Workouts.Where((x) =>x.ID ==1).ToList()},
                new User() {Name = "Einar", Password = "EinarRule5", Workouts = context.Workouts.Where((x) =>x.ID ==1 || x.ID ==1).ToList()},
                new User() {Name = "Sondre", Password = "Sonny123", Workouts = context.Workouts.Where((x) =>x.ID ==3 || x.ID ==1 || x.ID == 2).ToList()},
                new User() {Name = "Peder", Password = "Peder", Workouts = new List<Workout>()}
            };

            context.Users.AddRange(Users);
            context.SaveChanges();
        }

        public  List<Activity> Activities { get; set; } 

        public  List<Exercise> Exercises { get; set; } 

        public  List<Workout> Workouts { get; set; } 

        public  List<User> Users { get; set; } 
    }
}
