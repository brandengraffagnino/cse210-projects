using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "TechGuy", 600);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks!"));
        videos.Add(video1);

        Video video2 = new Video("Learn Python", "CodeMaster", 900);
        video2.AddComment(new Comment("Dave", "Awesome explanation."));
        video2.AddComment(new Comment("Eva", "I understand now."));
        video2.AddComment(new Comment("Frank", "Nice work!"));
        videos.Add(video2);

        Video video3 = new Video("Encapsulation in C#", "DevPro", 750);
        video3.AddComment(new Comment("Grace", "Clear and simple."));
        video3.AddComment(new Comment("Henry", "Good examples."));
        video3.AddComment(new Comment("Ivy", "Loved it."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetDisplayText());
            }

            Console.WriteLine();
        }
    }
}
