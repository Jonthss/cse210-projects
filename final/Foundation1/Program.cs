using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating videos and adding comments
        var video1 = new Video
        {
            Title = "Introduction to Programming",
            Author = "John Doe",
            Duration = 300,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Alice", CommentText = "Great video!" },
                new Comment { CommenterName = "Bob", CommentText = "I learned a lot." }
            }
        };

        var video2 = new Video
        {
            Title = "Object-Oriented Programming Concepts",
            Author = "Jane Smith",
            Duration = 450,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Charlie", CommentText = "Very informative." },
                new Comment { CommenterName = "David", CommentText = "Could use more examples." }
            }
        };

        // Putting videos in a list
        var videos = new List<Video> { video1, video2 };

        // Displaying video details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}
