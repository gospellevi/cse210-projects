using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        // Create video instances
        Video video1 = new Video("Ademola Lookman is the REAL DEAL", "360edition", 495);
        Video video2 = new Video("I'm A Thug", "William Last KRM", 70);
        Video video3 = new Video("C# Classes Tutorial | Mosh", "Programming with Mosh", 854);
        
        // Add comments to video1
        video1.AddComment(new Comment("@timothyojobo", "The next african footballer of the year, no doubt"));
        video1.AddComment(new Comment("@ericlamela371", "Adeballer Lookman"));    
        video1.AddComment(new Comment("@yusukemori4576", "I love the thumbnail"));

        // Add comments to video2
        video2.AddComment(new Comment("@Ontopic87", "….we thugs, we can't be on tv"));
        video2.AddComment(new Comment("@phathumatsa7633", "The staredowns are killing me"));    
        video2.AddComment(new Comment("@larrygarret4668", "This guy is fkn hilarious...love it. Thanks man, youre comedy is a joy."));

        // Add comments to video3
        video3.AddComment(new Comment("@nogamesnofame", "Goddamn, I finally found a youtuber whos voice does not bore me and teaches what I'm interested in!"));
        video3.AddComment(new Comment("@josphatoluoch5205", "Thanks a lot, You are changing the world bro!! :D"));    
        video3.AddComment(new Comment("@brandonnorris1026", "Made me believe that I could use var to call a Class from anywhere on earth."));

        // Create a list of videos
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"{video.GetComments().Count} Comments");
            // Console.WriteLine("Comments: ");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}