using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;
using LiftBroAPI.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LiftBroAPI.Entities
{
    public class Exercise : IEntity
    {
        public int ID { get; set; }

        public int Repitations { get; set; }
        public int Sets { get; set; }
        public double Weight { get; set; }

      
        public Activity Activity { get; set; }
    }
}