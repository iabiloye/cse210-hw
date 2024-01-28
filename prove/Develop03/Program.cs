using System;

class Program
{
    static void Main()
    {
        ScriptureReference reference = new ScriptureReference("John 3:16");
        Scripture scripture = new Scripture(reference, "For God so loved thFor God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        DisplayScripture(scripture);

        string input;
        do
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            input = Console.ReadLine();

            if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
                break;

            HideRandomWords(scripture);
            DisplayScripture(scripture);

        } while (!scripture.AllWordsHidden());

        Console.WriteLine("Program ended.");
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetFullScripture());
    }

    static void HideRandomWords(Scripture scripture)
    {
        scripture.HideRandomWords();
    }
}
