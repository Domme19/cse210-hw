using System.ComponentModel;
using System.Reflection.Metadata;
using System.Transactions;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random(); 


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //a text that needs to be split
        string[] extractedWords = text.Split(' ');
        for (int i = 0; i < extractedWords.Length; i++)
        {
            Word currentWord = new Word(extractedWords[i]);
            _words.Add(currentWord); 
            
        }
    }


    // HideRandomWords
    public void HideRandomWords(int numberToHide)
    {
        // 
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide(); 
        }
    }



     public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }

        return display.Trim();
    }


     public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            Word currentWord = _words[i];
            if (!currentWord.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}