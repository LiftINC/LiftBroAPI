using System;

namespace LiftBroAPI.Entities
{
    using LiftBroAPI.Entities.Models;
    using System.ComponentModel.DataAnnotations;
    public class Activity: IEntity
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
    }
}