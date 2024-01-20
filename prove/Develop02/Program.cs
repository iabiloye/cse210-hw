using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your full name: ");
        string userName = Console.ReadLine();
        Journal myJournal = new Journal(userName);

        List<string> notificationsList = new List<string>
        {
            "What was the most interesting thing I learned today?",
            "Describe a moment that made you laugh out loud today.",
            "What accomplishment are you most proud of today?",
            "If you could relive one moment from today, what would it be?",
            "What made you feel grateful today?",
            "In what ways did you challenge yourself today?",
            "If you could give one piece of advice to your past self today, what would it be?",
            "What new skill or knowledge did you acquire today?"
        };

        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("Please select one of the following choices?");
            Console.WriteLine("[1] Write");
            Console.WriteLine("[2] Display");
            Console.WriteLine("[3] Load");
            Console.WriteLine("[4] Save");
            Console.WriteLine("[5] Quit");
            Console.Write("What would you like to do? ");
            string optionChoose = Console.ReadLine();

            switch (optionChoose)
            {
                case "1":
                    WriteEntry(myJournal, notificationsList);
                    break;

                case "2":
                    DisplayEntries(myJournal);
                    break;

                case "3":
                    LoadFile(myJournal);
                    break;

                case "4":
                    SaveFile(myJournal);
                    break;

                case "5":
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose another option.");
                    break;
            }
        }
    }

    static void WriteEntry(Journal myJournal, List<string> notificationsList)
    {
        Random random = new Random();
        int num = random.Next(0, notificationsList.Count);

        Entry entry = new Entry
        {
            _message = notificationsList[num]
        };

        Console.WriteLine(entry._message);
        Console.Write("Enter your response: ");
        string userEntryResponse = Console.ReadLine();
        entry._response = char.ToUpper(userEntryResponse[0]) + userEntryResponse.Substring(1);

        myJournal.AddEntry(entry);
    }

    static void DisplayEntries(Journal myJournal)
    {
        Console.WriteLine("------------------------------------------------------");
        myJournal.Display();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("To save the current list, please save it.");
    }

    static void LoadFile(Journal myJournal)
    {
        Console.Write("What is the file's name? (Ex. myFile.csv) ");
        string fileNameToLoad = Console.ReadLine();

        if (File.Exists(fileNameToLoad))
        {
            myJournal.LoadFile(fileNameToLoad);
            Console.WriteLine("File loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static void SaveFile(Journal myJournal)
    {
        Console.Write("What is the file's name? (Ex. myFile.csv) ");
        string fileNameToSave = Console.ReadLine();
        myJournal.SaveFile(fileNameToSave);
    }
}

