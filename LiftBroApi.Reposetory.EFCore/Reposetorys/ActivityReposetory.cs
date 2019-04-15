using LiftBroApi.Reposetory.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Text;
using LiftBroAPI.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace LiftBroApi.Reposetory.EFCore.Reposetorys
{
    public class ActivityReposetory : IActivityReposetory
    {
        private LiftBroContext context { get; set; }


        public ActivityReposetory(LiftBroContext context)
        {
            this.context = context;
        }

        public void Delete(Activity entity)
        {
            context.Activities.Remove(entity);
        }

        public IQueryable<Activity> GetAll()
        {
            return context.Activities;
        }

        public Activity GetById(int id)
        {
            return context.Activities.FirstOrDefault(x => x.ID ==id);
        }

        public void Insert(Activity entity)
        {
            context.Activities.Update(entity);
            context.SaveChanges();
        }

        public IQueryable<Activity> SearchFor(Expression<Func<Activity, bool>> predicate)
        {
            return context.Activities.Where(predicate);
        }
    }
}
