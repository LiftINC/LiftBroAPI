using LiftBroAPI.Entities.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace LiftBroAPI.Entities
{
    public class User : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

       
        public virtual ICollection<Workout> Workouts { get; set; }
        
    }
}