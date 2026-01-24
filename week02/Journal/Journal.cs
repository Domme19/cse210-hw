using System.ComponentModel;
using System.Xml.Linq;
using System.IO;
using System.Transactions;


class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Entry currentEntry = _entries[i]; 
            Console.WriteLine($"Date: {currentEntry._date} - Prompt: {currentEntry._promptText} {currentEntry._entryText}");
            Console.WriteLine(); 
        }
    }

    public void SaveToFile(string file)
    {
        // TODO
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            // create the lines
            for (int i = 0; i < _entries.Count; i++)
            {
                Entry currentEntry = _entries[i];
                string entryToString = $"Date: {currentEntry._date} - Prompt: {currentEntry._promptText} {currentEntry._entryText}";
                outputFile.WriteLine(entryToString);
            }
        }
        
    }

    public void LoadFromFile(string file)
    {
        // TODO
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.Write($"{line}\n");
            // Console.WriteLine();
        }

    }

}