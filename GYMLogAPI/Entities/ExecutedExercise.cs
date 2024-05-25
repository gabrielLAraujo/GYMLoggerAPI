namespace GYMLogAPI.Entities
{
    public class ExecutedExercise
    {
        public string Token { get; set; }
        public Exercise exercise { get; set; }
        public Range Repetitions { get; set; }
        public float Load {  get; set; }
    }
}
