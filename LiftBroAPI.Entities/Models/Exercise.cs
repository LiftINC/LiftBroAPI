using System.Transactions;

namespace LiftBroAPI.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        public Activity Activity { get; set; }
        public int Repitations { get; set; }
        public int Sets { get; set; }
        public double Weight { get; set; }
    }
}