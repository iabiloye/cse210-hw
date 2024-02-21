using System;

namespace InheritanceWithEventPlanning
{
    public class Reception : Event
    {
        private string rsvpEmail;

        public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $"\nRSVP Email: {rsvpEmail}";
        }
    }
}
