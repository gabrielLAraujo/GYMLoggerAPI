namespace GYMLogAPI.Entities
{
    public class TrainningSession
    {
        public WeekPlanning Planning { get; set; }
        public ExecutedExercise exercise { get; set; }
        DateTime Date { get; set; }
        public User User { get; set; }
    }
}
