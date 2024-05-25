namespace GYMLogAPI.Entities
{
    public class PlannedExercise
    {
        public string Token { get; set; } 
        public Exercise Exercise { get; set; }
        public Range RepetionRange { get; set; }
        public User User { get; set; }
    }
}
