using System.Collections.Generic;

namespace LiftBroAPI.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
        public string Name { get; set; }
    }
}