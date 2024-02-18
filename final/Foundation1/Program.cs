// Program 1: Abstraction with youtube video
// Author: Abiloye Iyanuoluwa John

using System;

namespace AbstractionWithYouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a video
            Video video = new Video("Web Development Tutorial Video", " By Abiloye Iyanuoluwa John", 640);

            // Adding comments
            video.AddComment(new Comment("Joseph Adat", "Great tutorial for me to learn easily!"));
            video.AddComment(new Comment("Afangideh Promise", "Very helpful guide, thanks!"));
            video.AddComment(new Comment("Blessing Emmanuel Udoh", "This was a fantastic class, Wow!"));
            video.AddComment(new Comment("Peculiar Emediong Emmanuel ", "Do you have such beautiful tutorial for C# ?. Please share the link, thanks!"));



            // Displaying information
            video.DisplayInformation();
        }
    }
}
