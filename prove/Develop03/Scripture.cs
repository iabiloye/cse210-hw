using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private ScriptureReference reference;
    private string text;
    private List<Word> words;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetFullScripture()
    {
        return $"{reference} {text}";
    }

    public void HideRandomWords()
    {
        int wordsToHide = 2;

        // Get a list of words that are not already hidden
        List<Word> visibleWords = words.Where(word => !word.IsHidden).ToList();

        // Randomly select words to hide
        Random random = new Random();
        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}
