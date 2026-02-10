using System.ComponentModel.Design;
using System.Data;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

class Video
{
      private string _title;
      private string _author;
      private int _length;
      private static int suffixNumber = 1100;
      private string currentVideoId = "";
        private List<Comment> _comments = new List<Comment>();


    
    private string createRandomId()
    {
        suffixNumber += 1;
        string videoId = "VD" + suffixNumber.ToString();
        return videoId;
    }

      public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        currentVideoId = createRandomId();
    }


    // getters
    public string GetTitle()
    {
        return _title;
    }


    public string GetAuthor()
    {
        return _author;
    }


    public int GetLength()
    {
        return _length;
    }


    public string GetVideoId()
    {
        return currentVideoId;
    }


    // comment method
    public void AddComment(string author, string textContent)
    {
        if (currentVideoId == "")
        {
            Console.WriteLine("Create the video first"); 
            return;
        }
        Comment newComment = new Comment(currentVideoId, author, textContent);
        _comments.Add(newComment);
    }


    public int GetCommentCount()
    {
        return _comments.Count;
    }


    public void ViewComments()
    {
        for (int i = 0; i < _comments.Count; i++)
        {
            Comment currentComment = _comments[i];
            Console.WriteLine($"{currentComment.GetAuthor()} - {currentComment.GetTextContent()}"); 
        }
    }
}