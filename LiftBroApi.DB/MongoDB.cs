using MongoDB.Driver;

namespace LiftBroApi.DB
{
    public class MongoDB
    {
        public MongoDB()
        {
            var connectionString = "mongodb+srv://Fingann:stemmer123@cluster0-hznrv.mongodb.net/test?retryWrites=true";
            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("Workout");
            CreateCollection(db);
           

        }

        public async void CreateCollection(IMongoDatabase db)
        {
            await db.CreateCollectionAsync("Workouts", new CreateCollectionOptions
            {
                AutoIndexId = true,
            });
        }
        
    }
}