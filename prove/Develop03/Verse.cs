public class Verse
{
    
    private string _verse = "";
    private int _listWordCount = 0;

    private List<Word> _wordList = new();

    private List<int> _indexList = new();


    public Verse(string verse)
    {
        _verse = verse;
        SplitVerse();
        GetWordCount();
        IndexList();
    }

    public List<Word> SplitVerse()
    {
        string[] verseSplit = _verse.Split(" ");
        foreach (string word in verseSplit)
        {
            Word word1 = new Word(word);
            
            _wordList.Add(word1);
        }
    
    return _wordList;
    }

    public int GetWordCount()
    {
        _listWordCount = _wordList.Count();
        
        return _listWordCount;
    }

    public void IndexList()
    {
        int i = 0;
        foreach (Word word in _wordList)
        {
            _indexList.Add(i);
            i++;
        }
    }
    
    public bool RemoveRandomWords()
    {
        if (_indexList.Count() > 0)
        {
            Random random = new Random();
            int x = random.Next(0, _indexList.Count());
            int i = _indexList[x];
            
            _wordList[i].Hide();

            _indexList.RemoveAt(x); 
            return true;
        } 

        else
        {
            Console.WriteLine("\nAll words are hidden.\n");
            return false;
        }
    }
    
    public void Display()
    {   
        if (_indexList != null)
        {
            foreach (Word word in _wordList)
            {
                word.Display();
                Console.Write(" ");
            }
        }
        else
        {
            // Console.WriteLine("All words are hidden.");
            
            foreach (Word word in _wordList)
            {
                word.Display();
                Console.Write(" ");
            }
        }
        Console.WriteLine($"\nWords visable: {_indexList.Count()}.  Words hidden: {_wordList.Count() - _indexList.Count()}.");
    }

}