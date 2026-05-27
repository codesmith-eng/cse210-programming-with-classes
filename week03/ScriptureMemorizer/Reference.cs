using System;

public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;



    // ---------- constructors-------------------------
    //-----------1st constructor--------------------------
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }


    //------2nd constructor
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }




    //--------------method---------------
    //--------if _endVerse equals to nothing return the first if statement, else return the second
    //
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return _book + " " + _chapter + ":" + _verse + ":";
        }
        else
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse + ":";
        }
    }


}