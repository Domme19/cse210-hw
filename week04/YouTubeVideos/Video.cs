using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;

class Video
{
      private string _title;
      private string _author;
      private int _length;

      private int suffix = 1100;
      private string currentVideoId = "";


    //   an internal function that creates the id;
    private string createRandomId()
    {
        // increment
        suffix += 1;
        Console.WriteLine($"The current suffix is: {suffix}");
        string videoId = "VD" + suffix.ToString();
        return videoId;
    }

      public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        currentVideoId = createRandomId();
    }


    public string GetVideoId()
    {
        return currentVideoId;
    }
}