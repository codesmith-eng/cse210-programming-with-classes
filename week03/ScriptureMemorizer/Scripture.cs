using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    private Random _random = new Random();



    //------constructor----
    //passing the list as variable to the scripture constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        //split sentence into words
        string[] words = text.Split(" ");

        //creating new word objects
        foreach (string part in words)
        {
            Word word = new Word(part);
            _words.Add(word);
        }

    }


    //---------methods----------------------
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> visibleWords = new List<Word>();

            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    visibleWords.Add(word);
                }
            }

            if (visibleWords.Count == 0)
            {
                return;
            }

            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();
        }
    }

    //----------------get the scripture display text
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.Trim();
    }

    //------------check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}