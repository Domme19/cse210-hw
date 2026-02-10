using System.Dynamic;

class Comment
{
    private string _videoId;
    private string _author;
    private string _textContent;

    public Comment(string videoId, string author, string textContent)
    {
        _videoId = videoId; 
        _author = author;
        _textContent = textContent;   
    }


    public string GetAuthor()
    {
        return _author;
    }


    public string GetTextContent()
    {
        return _textContent;
    }
}