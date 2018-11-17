using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiftBroAPI.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LiftBroAPI.Entities
{
    public class Workout : IEntity
    {
        public int ID { get; set; }
        public virtual ICollection<Exercise> Exercises { get; set; }
        public string Name { get; set; }

    }
}