using System;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {



        List <Video> videoList = new List<Video>(); 
        // first video
        Video video1 = new Video("Papa", "La Fouine", 3);
        video1.AddComment("Domme Mabounda", "this is a nice song to listen to.");
        video1.AddComment("Uvelle Mabounda", "One of the best song ever");
        video1.AddComment("Dorval Mabounda", "This is something I can listen to the whole day.");
        videoList.Add(video1); 

        // second video
        Video video2 = new Video("Seul", "Garou", 4);
        video2.AddComment("John Curry", "Great single from Garou, one of the best");
        video2.AddComment("Kelly Smith", "This is so great!");
        video2.AddComment("Colby Summer", "I guess I'll have to replay this my entire life.");
        video2.AddComment("Jerry West", "Music like this should never disappear.");
        Console.WriteLine($"The number of comments are: {video2.GetCommentCount()} ");
        videoList.Add(video2); 

        // third video
        Video video3 = new Video("I'm alive", "Celine Dion", 4);
        video3.AddComment("Gary Johnson", "Unbelievable!");
        video3.AddComment("Kirk Flynn", "This lady can sing her heart out!");
        video3.AddComment("Ben Curry", "Wish I found her music before.");
        video3.AddComment("Johnny Kirk", "She deserves any award available for this masterpiece.");
        video3.AddComment("Allen Campbell", "This is the kind of music we should hear more often.");
        videoList.Add(video3); 

        for (int i = 0; i < videoList.Count; i++)
        {
            Video currentVideo = videoList[i];
            Console.WriteLine("---------------------------------------"); 
            Console.WriteLine($"Title - {currentVideo.GetTitle()}");
            Console.WriteLine($"Author - {currentVideo.GetAuthor()}");
            Console.WriteLine($"Length - {currentVideo.GetLength()}");
            Console.WriteLine($"Number of Comments - {currentVideo.GetCommentCount()}"); 
            Console.WriteLine("-------Comments-------------------------"); 
            currentVideo.ViewComments(); 

        }


    }

}