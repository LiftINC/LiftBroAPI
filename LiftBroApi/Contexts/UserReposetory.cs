using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftBroAPI.Entities;

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
        return _context.Users.ToList();
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
