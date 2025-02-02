using System;

public class Journal()
{
    List<Entry> _userEntries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.AssignNewAll();

        _userEntries.Add(entry);
    }


    public void DisplayAll()
    {
        foreach (Entry entry in _userEntries)
        {
            entry.Display();
        }
    }


    public void LoadFile()
    {
        Console.Write("Please enter the file name(ex: filname.txt): ");
        string fileName = Console.ReadLine();

        List<Entry> loadedEntries = new List<Entry>();

        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            entry.LoadExistingDate(date);
            entry.LoadExistingPrompt(prompt);
            entry.LoadExistingText(text);

            loadedEntries.Add(entry);
        }
        _userEntries = loadedEntries;
    }


    public void Save(bool Overwrite = false)
    {
        Console.Write("Please enter the file name(ex: filname.txt): ");
        string fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(fileName, Overwrite))
        {
            foreach (Entry entry in _userEntries)
            {
                file.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetEntryText()}");
            }
        }
    }
}