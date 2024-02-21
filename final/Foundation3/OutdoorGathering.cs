using System;

namespace InheritanceWithEventPlanning
{
    public class OutdoorGathering : Event
    {
        private string weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            this.weatherForecast = weatherForecast;
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $"\nWeather Forecast: {weatherForecast}";
        }
    }
}
