using LiftBroAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftBroApi.Contexts
{
    public interface IUserReposetory: IDisposable
    {
      
        IEnumerable<User> GetUsers();
        IEnumerable<Workout> GetWorkouts();
        IEnumerable<Exercise> GetExercises();
        IEnumerable<Activity> GetActivitys();

        void InsertUser(User user);

    void Save();
}
}

