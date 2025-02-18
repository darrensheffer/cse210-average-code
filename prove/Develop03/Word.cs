public class Word
{
    private string _word;

    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Display()
    {
        if (_isHidden == true)
        {  
            Console.Write("____");
        }
        
        else
        {
            Console.Write(_word);

        }
        
    }
}