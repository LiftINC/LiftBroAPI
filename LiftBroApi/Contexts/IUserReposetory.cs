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

    void InsertUser(User user);

    void Save();
}
}

