using System;

namespace InheritanceWithEventPlanning
{
    public class Event
    {
        protected string title;
        protected string description;
        protected DateTime date;
        protected DateTime time;
        protected Address address;

        public Event(string title, string description, DateTime date, DateTime time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public virtual string GetSummary()
        {
            return $"Event: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address}";
        }
    }
}
