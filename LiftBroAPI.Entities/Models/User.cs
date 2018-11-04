using System.Collections.Generic;
using System.Reflection.Metadata;

namespace LiftBroAPI.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<Workout> Workouts { get; set; }
        
    }
}