using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftBroAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LiftBroApi.Controllers
{
    [Route("api/[controller]")]
    public class WorkoutController : Controller
    {
        // GET api/values
            // GET api/values
        [HttpGet]
        public IEnumerable<Workout> Get()
        {
            return new List<Workout>()
            {
                new Workout()
                {
                    Id = 1,
                    Name = "Workout 1",
                    Exercises = new List<Exercise>()
                    {
                        new Exercise()
                        {
                            Id = 2,
                            Repitations = 5,
                            Sets = 3,
                            Weight = 50,
                            Activity = new Activity()
                            {
                                Id = 1,
                                Name = "Squats"
                            }
                        },
                        new Exercise()
                        {
                            Id = 1,
                            Repitations = 5,
                            Sets = 3,
                            Weight = 50,
                            Activity = new Activity()
                            {
                                Id = 2,
                                Name = "BenchPress"
                            }
                        },
                        new Exercise()
                        {
                            Id = 1,
                            Repitations = 5,
                            Sets = 3,
                            Activity = new Activity()
                            {
                                Id = 3,
                                Name = "Pushups"
                            }
                        }
                    }
                }

            };
        }
        

        // GET api/values/5
            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "Workout" + id.ToString();
            }

            // POST api/values
            [HttpPost]
            public void Post([FromBody] string value)
            {
              
            }

            // PUT api/values/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }
