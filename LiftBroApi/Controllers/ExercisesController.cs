using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftBroApi.Contexts;
using LiftBroAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LiftBroApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ExercisesController : Controller
    {
        private readonly IUserReposetory _context;

        public ExercisesController(IUserReposetory context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<Exercise> GetUsers()
        {
            return _context.GetExercises();
        }

        //// GET: api/Users
        //[HttpGet]
        //public IEnumerable<Workout> GetWorkouts()
        //{
        //    return _context.GetWorkouts();
        //}

        //// GET: api/Users/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUser([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var user = _context.g

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(user);
        //}

        //// PUT: api/Users/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUser([FromRoute] int id, [FromBody] User user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != user.ActivityId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.InsertUser(user);

        //    try
        //    {
        //        _context.Save();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Users
        //[HttpPost]
        //public async IActionResult PostUser([FromBody] User user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //_context.InsertUser(user);


        //        _context.Save();

        //        return "OK"; 
        //       //CreatedAtAction("GetUser", new { id = user.ActivityId }, user);
        //}

        //// DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUser([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var user = await _context.Users.SingleOrDefaultAsync(m => m.ActivityId == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Users.Remove(user);
        //    await _context.SaveChangesAsync();

        //    return Ok(user);
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.ActivityId == id);
        //}
    }
}