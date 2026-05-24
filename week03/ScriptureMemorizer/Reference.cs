using System;

public class Reference
{
    private string _date;
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
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return _book + " " + _chapter + ":" + _verse +":";
        }
        else
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse + ":";
        }
    }




    // ------setters----------------------
    public void SetBook(string book)
    {
        _book = book;
    }


    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }



    // -------getters-------------------------------------
    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

}

