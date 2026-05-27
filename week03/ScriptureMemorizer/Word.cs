using System;

// The main job of this word class is to represent a single word in the scripture memorization program. 
// It keeps track of two things: what the word is, and whether it should be visible 
// or hidden (replaced by underscores) on the screen.


//Summary of this class works in action:
// Imagine the program creates the word "Apple".

// At first, GetDisplayText() returns "Apple".

// The program calls .Hide().

// Now, GetDisplayText() returns "_____".

public class Word
{
    //stores actual word in the list in the scripture class
    private string _text;

    //checks whether the word is hidden
    //if false, the word is visible
    //if true is hidden
    private bool _isHidden;



    //-----constructor for Word class-----------------------
    public Word(string text)
    {
        _text = text; //Save the word

        //the word starts visible
        _isHidden = false;   //the word starts visible first
    }



    //------- Show the word again--------
    public void Show()
    {
        //Make the word visible
        _isHidden = false;
    }


    //----------this method hide the word when enter is pressed
    public void Hide()
    {
        //--------- Hide the word when enter is pressed
        _isHidden = true;
    }



    //-------check if word is hidden------------
    public bool IsHidden()
    {
        //-----return true or false
        return _isHidden;
    }

    //This method decides what gets printed to the screen
    public string GetDisplayText()
    {
        //calling _isHidden to check if is true or false
        if (_isHidden)
        {
            //if _isHidden is true, meaning if the word are truly hidden, show underscore for the same length of words hidden
            return new string('_', _text.Length);
        }

        //if _isHidden is false, meaning, no word is hidden, just return the original word
        return _text;
    }
}
