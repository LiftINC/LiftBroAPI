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
    public class UserReposetory : IUserReposetory
    {
        private LiftBroContext context { get; set; }


        private IIncludableQueryable<User,Activity> userContext() => context.Users.Include(user => user.Workouts).ThenInclude(workout => workout.Exercises).ThenInclude(exercise => exercise.Activity);
        public UserReposetory(LiftBroContext context)
        {
            this.context = context;
        }

        public void Delete(User entity)
        {
            context.Users.Remove(entity);
        }

        public IQueryable<User> GetAll()
        {
            var x = context.Users.Include(user => user.Workouts).ThenInclude(workout => workout.Exercises).ThenInclude(exercise => exercise.Activity);
            return x;
        }

        public User GetById(int id)
        {
            return userContext().FirstOrDefault(X => X.ID == id);
        }

        public void Insert(User entity)
        {
            context.Users.Update(entity);
            context.SaveChanges();
        }

        public IQueryable<User> SearchFor(Expression<Func<User, bool>> predicate)
        {
            return userContext().Where(predicate);
        }
    }
}
