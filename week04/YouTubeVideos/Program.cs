using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        List<Comment> video1Comments = new List<Comment>();
        video1Comments.Add(new Comment("arthur123", "I thought this video was very interesting LOL"));
        video1Comments.Add(new Comment("Gusta213", "nice"));
        video1Comments.Add(new Comment("Lipe2", "Why not?"));
        Video video1 = new Video("How to be rich", "vini1", 120, video1Comments);
        videos.Add(video1);

        List<Comment> video2Comments = new List<Comment>();
        video2Comments.Add(new Comment("Alice99", "Great content!"));
        video2Comments.Add(new Comment("Bob77", "Could be better, but I liked it."));
        video2Comments.Add(new Comment("CharlieX", "Awesome!"));
        Video video2 = new Video("The incredible life of Albert", "vini2", 300, video2Comments);
        videos.Add(video2);

        List<Comment> video3Comments = new List<Comment>();
        video3Comments.Add(new Comment("Eve_01", "Loved the editing!"));
        video3Comments.Add(new Comment("Dave21", "Informative and well explained."));
        video3Comments.Add(new Comment("Frank45", "Can't wait for the next one!"));
        Video video3 = new Video("Frankenstein", "vini3", 501, video3Comments);
        videos.Add(video3);

        Console.Clear();
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetUserName()}: {comment.GetComment()}");
            }
            Console.WriteLine();
        }

    }
}