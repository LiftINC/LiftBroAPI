using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LiftBroApi.Reposetory.Interfaces;
using LiftBroAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace LiftBroApi.Reposetory.EFCore.Reposetorys
{
    public class WorkoutReposetory : IWorkoutReposetory
    {
        private LiftBroContext context { get; set; }


        private IIncludableQueryable<Workout, Activity> userContext() => context.Workouts.Include(workout => workout.Exercises).ThenInclude(exercise => exercise.Activity);
        public WorkoutReposetory(LiftBroContext context)
        {
            this.context = context;
        }

        public void Delete(Workout entity)
        {
            context.Workouts.Remove(entity);
        }

        public IQueryable<Workout> GetAll()
        {
            var x = context.Workouts.Include(workout => workout.Exercises).ThenInclude(exercise => exercise.Activity);
            return x;
        }

        public Workout GetById(int id)
        {
            return userContext().FirstOrDefault(X => X.ID == id);
        }

        public void Insert(Workout entity)
        {
            context.Workouts.Update(entity);
            context.SaveChanges();
        }

        public IQueryable<Workout> SearchFor(Expression<Func<Workout, bool>> predicate)
        {
            return userContext().Where(predicate);
        }
    }
}

