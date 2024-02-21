namespace PolymorphismWithExerciseTracking
{
    public class Running : Activity
    {
        private double distance;

        public Running(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
        {
            this.distance = distance;
        }
        public override double GetDistance()
        {
            return distance;
        }
        public override double GetSpeed()
        {
            return distance / (lengthInMinutes / 60.0);
        }
        public override double GetPace()
        {
            return lengthInMinutes / distance;
        }
        public override string GetSummary()
        {
            return $"{date} Running ({lengthInMinutes} min) - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
    }
}
