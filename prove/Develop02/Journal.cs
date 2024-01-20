using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _name;
    public List<Entry> _entries = new List<Entry>();

    public Journal(string name)
    {
        _name = char.ToUpper(name[0]) + name.Substring(1);
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: {entry._message}");
            Console.WriteLine($"{entry._response}");
        }
    }

    public void SaveFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("------------------------------------------------------");
            outputFile.WriteLine($"Name: {_name}");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: {entry._message}");
                outputFile.WriteLine($"{entry._response}");
            }

            outputFile.WriteLine("------------------------------------------------------");
        }

        Console.WriteLine("File saved successfully.");
    }

    public void LoadFile(string fileName)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            // Assuming the file format is consistent with the expected entry structure.
            // You may need to adapt this based on your actual file format.
        }
    }
}
