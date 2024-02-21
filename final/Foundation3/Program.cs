using System;

namespace InheritanceWithEventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating events
            Address eventAddress = new Address("68 Etta-agbor", "Calabar", "CRS", "NG");

            // Creating a DateTime object for the time parameter with a default time
            DateTime defaultTime = DateTime.Today.AddHours(18).AddMinutes(0); // Setting time to 6:00 PM

            Lecture lecture = new Lecture("English For Professional", "Rhetorical Analysis", DateTime.Now.Date, defaultTime, eventAddress, "Sis Mathyr Carolyne", 130);
            Reception reception = new Reception("Networking", "Power Statement for LinkedIn", DateTime.Now.Date, defaultTime, eventAddress, "iqweet@outlook.com");
            OutdoorGathering gathering = new OutdoorGathering("Career Development", "LinkedIn Connect", DateTime.Now.Date, defaultTime, eventAddress, "Day");

            // Displaying event summaries
            Console.WriteLine("Lecture Summary:");
            Console.WriteLine(lecture.GetSummary());

            Console.WriteLine("\nReception Summary:");
            Console.WriteLine(reception.GetSummary());

            Console.WriteLine("\nOutdoor Gathering Summary:");
            Console.WriteLine(gathering.GetSummary());
        }
    }
}
