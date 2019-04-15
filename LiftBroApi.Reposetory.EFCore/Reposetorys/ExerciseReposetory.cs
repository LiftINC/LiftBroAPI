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
    public class ExerciseReposetory : IExerciseReposetory
    {
        private LiftBroContext context { get; set; }


        private IIncludableQueryable<Exercise, Activity> exerciseContext() => context.Exercises.Include(exercise => exercise.Activity);
        public ExerciseReposetory(LiftBroContext context)
        {
            this.context = context;
        }

        public void Delete(Exercise entity)
        {
            context.Exercises.Remove(entity);
        }

        public IQueryable<Exercise> GetAll()
        {
            var x = context.Exercises.Include(exercise => exercise.Activity);
            return x;
        }

        public Exercise GetById(int id)
        {
            return exerciseContext().FirstOrDefault(X => X.ID == id);
        }

        public void Insert(Exercise entity)
        {
            context.Exercises.Update(entity);
            context.SaveChanges();
        }

        public IQueryable<Exercise> SearchFor(Expression<Func<Exercise, bool>> predicate)
        {
            return exerciseContext().Where(predicate);
        }
    }
}
