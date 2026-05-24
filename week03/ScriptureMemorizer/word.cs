using System;


public class Word
{
    //stores actual word in the list in the scripture class
    private string _text;

    //checks whether the word is hidden
    //if false = visible
    //if true = hidden
    private bool _isHidden;

    //-----constructor for Word class-----------------------
    public Word(string text)
    {
        _text = text; //Save the word

        //the word starts visible
        _isHidden = false;
    }

    //-------------methods-----------------
    //----------this method hide the word
    public void Hide()
    {
        //--------- Hide the word
        _isHidden = true;
    }

    //------- Show the word again--------
    public void Show()
    {
        //Make the word visible
        _isHidden = false;
    }

    //-------check if word is hidden------------
    public bool IsHidden()
    {
        //-----return true or false
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //If hidden, show underscores
        if (_isHidden)
        {
            //create underscores as same length as word
            return new string('_', _text.Length);
        }

        //otherwise show actual word
        return _text;
    }
}