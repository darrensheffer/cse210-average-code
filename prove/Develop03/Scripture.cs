class Scripture
{
    Reference _reference;
    Verse _firstVerse;
    Verse _lastVerse;


    public Scripture(Reference reference, Verse verse)
    {
        _reference = reference;
        _firstVerse = verse;
    } 
    
    public Scripture(Reference reference, Verse firstVerse, Verse lastVerse)
    {
        _reference = reference;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public void Display()
    {
        Console.WriteLine();
        _reference.Display();
        _reference.FirstVerseNumber(); _firstVerse.Display();
        if (_reference.SecondVerseNumber() != 0)
        {
            Console.Write($"{_reference.SecondVerseNumber()}. "); _lastVerse.Display();
        }
        
    }
}
