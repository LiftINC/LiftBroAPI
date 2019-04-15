using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiftBroAPI.Entities
{
    public class Workout
    {
        [BsonId]
        // standard BSonId generated by MongoDb
        public ObjectId InternalId { get; set; }        public ICollection<Exercise> Exercises { get; set; }
        public string Name { get; set; }
    }
}