using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _promptsList = new List<string>
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

    public string ChooseRandom()
    {
        return _promptsList[new Random().Next(0, _promptsList.Count)];
    }
}
