using System;

namespace InheritanceWithEventPlanning
{
    public class Lecture : Event
    {
        private string speaker;
        private int capacity;

        public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $"\nSpeaker: {speaker}\nCapacity: {capacity}";
        }
    }
}
