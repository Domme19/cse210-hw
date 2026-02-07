using System;
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        // Youtube app
        // TODO: BUILD CLASS

        Video video1 = new Video("La fouine - Papa", "Evard Mabounda", 3);
        string video1Id = video1.GetVideoId();
        Console.WriteLine($"The first id: {video1Id}");


        Video video2 = new Video("La Fouine - D'ou l'on vient", "Evard Mabounda", 4);
        string video2Id = video1.GetVideoId();
        Console.WriteLine($"The second video id: {video2Id}");
    }
    
}