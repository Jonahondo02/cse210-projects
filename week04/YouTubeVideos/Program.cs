using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        
        // Create a list to hold videos
        List<Video> videoList = new List<Video>();

        // Create Video objects and add comments
        Video video1 = new Video("Travel Vlog", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Loved the scenery!"));
        video1.AddComment(new Comment("Charlie", "Awesome tips!"));
        videoList.Add(video1);

        Video video2 = new Video("Cooking Tutorial", "Jane Smith", 200);
        video2.AddComment(new Comment("Dave", "Yummy recipe!"));
        video2.AddComment(new Comment("Eva", "Can't wait to try this!"));
        video2.AddComment(new Comment("Frank", "Looks delicious!"));
        videoList.Add(video2);

        Video video3 = new Video("Tech Review", "Bob Tech", 400);
        video3.AddComment(new Comment("Grace", "I want this gadget!"));
        video3.AddComment(new Comment("Hank", "Very informative, thanks!"));
        video3.AddComment(new Comment("Ivy", "You explained it well!"));
        videoList.Add(video3);

        // Iterate through the list of videos and display information
        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}