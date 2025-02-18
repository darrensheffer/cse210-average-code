using System;

public class Reference
{
    private string _book;
    
    private int _chapter;

    private int _firstVerse;

    private int _lastVerse;

    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = 0;
    }
    
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    

    public void FirstVerseNumber()
    {
        Console.Write($"{_firstVerse}. ");
    }

    public int SecondVerseNumber()
    {
        return _lastVerse;
    }

    public void Display()
    {
        if (_lastVerse != 0)
        {
            Console.WriteLine($"{_book}:{_chapter} {_firstVerse}-{_lastVerse}");
        }

        else
        {
            Console.WriteLine($"{_book}:{_chapter} {_firstVerse}");
        }   
    }
}
   