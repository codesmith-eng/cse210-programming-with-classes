using System;
using System.Collections.Generic;

// This is the Scripture class. If the Word class you looked at earlier is a single building block, 
// the Scripture class is the manager that holds all those blocks together.
// Its job is to hold the scripture reference (like "John 3:16"), chop the verse into a list of individual 
// Word objects, and handle hiding random words until everything is gone.
public class Scripture
{
    private Reference _reference;

    //This is a dynamic list (like a collection or array) that will hold all the individual Word objects we create.
    private List<Word> _words = new List<Word>();  

    private Random _random = new Random();  //This is a random-number generator used later to pick which words to hide.

    //------constructor----
    //passing the _words list and string text to the scripture constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // This chops the long verse into a list of individual strings everywhere there is a space. 
        // "For God so loved" becomes ["For", "God", "so", "loved"]
        string[] words = text.Split(" ");

        // The foreach loop: It takes each of those chopped strings, plugs it into the Word class 
        // to create a proper Word object, and adds it to the _words list.
        foreach (string part in words)
        {
            //Adding the chopped strings to the _words list
            Word word = new Word(part);
            _words.Add(word);
        }

    }


    //---------methods----------------------
    // This method is designed to hide a specific number of words (e.g., hide 3 words at a time).
    public void HideRandomWords(int numberToHide)
    {
        //for loop that iterate the chopped words
        for (int i = 0; i < numberToHide; i++)
        {
            // Why does it build a visibleWords list? It does this so it doesn't accidentally 
            // try to hide a word that is already hidden. It makes a temporary list of only the words you can still see.
            List<Word> visibleWords = new List<Word>();

            //Find all words that are NOT hidden yet
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    visibleWords.Add(word);
                }
            }

            // If temporary list is empty, stop immediately
            if (visibleWords.Count == 0)
            {
                return;
            }

            // Pick a random word from the temporary list and hide it
            
            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();
        }
    }



    // -------------What GetDisplayText() does--------------------------------------------
    // It starts by getting the reference text (e.g., "Proverbs 3:5 ").
    // It loops through every single Word object in its list and asks it for its display text using word.GetDisplayText().
    // Remember your Word class? If a word is hidden, it will hand back underscores (____). If it's not, it hands back the text.
    // .Trim() just cleans up any accidental extra spaces left at the very end.
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.Trim();
    }



//  ------------------------------------------
// It scans the list. If it finds even one word that is still visible (!word.IsHidden()), it immediately says false.
// If it checks the whole list and finds absolutely no visible words, it returns true.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Found a visible word! So it's not completely hidden.
            }
        }
        return true; // Looked at all words, none were visible.
    }
}