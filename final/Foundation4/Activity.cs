namespace PolymorphismWithExerciseTracking
{
    public abstract class Activity
    {
        protected string date;
        protected int lengthInMinutes;

        public Activity(string date, int lengthInMinutes)
        {
            this.date = date;
            this.lengthInMinutes = lengthInMinutes;
        }
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();
        public abstract string GetSummary();
    }
}
