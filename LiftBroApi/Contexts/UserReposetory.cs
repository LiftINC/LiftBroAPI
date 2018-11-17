using LiftBroAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using Microsoft.EntityFrameworkCore;

namespace LiftBroApi.Contexts
{
    public class UserReposetory : IUserReposetory { 
    private readonly LiftBroContext _context;

    public UserReposetory(LiftBroContext context)
    {
    _context = context;
    }

    public IEnumerable<User> GetUsers()
    {

        return _context.Users
            .Include(user => user.Workouts)
                .ThenInclude(workouts => workouts.Exercises)
                .ThenInclude(exercises => exercises.Activity);
    }
        public IEnumerable<Workout> GetWorkouts()
        {
            return _context.Workouts.Include(workouts => workouts.Exercises)
                .ThenInclude(exercises => exercises.Activity);
        }

        public IEnumerable<Exercise> GetExercises()
        {
            return _context.Exercises.Include(x => x.Activity);
        }

        public IEnumerable<Activity> GetActivitys()
        {
            return _context.Activities;
        }

        public void InsertUser(User user) => _context.Users.Add(user);

    public void Save()
    {
        _context.SaveChanges();
    }

    private bool _disposed;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
    {
    if (disposing)
    {
        _context.Dispose();
    }
    }
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

       
    }
}
