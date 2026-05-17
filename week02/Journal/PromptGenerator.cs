using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //creating a list of strings 
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What is the benefit of partaking the sacrament? ",
        "What is the fastest way to code? ",
        "How can I love my Heavenly Father",
        "What does scriptures says about Love",
        "How can I love my Neighbor as myself"
    };

    //method for generating a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

}