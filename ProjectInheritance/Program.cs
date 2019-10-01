using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday card", true, "James");
            Console.WriteLine(post1.ToString());

            ImagePost imagepost1 = new ImagePost("Check out my new shoes", "James", "https://images.com/shoes", true);
            Console.WriteLine(imagepost1.ToString());

            VideoPost videopost1 = new VideoPost("Coding Video", "James", "https://video.com/coding", true, 20);
            Console.WriteLine(videopost1.ToString());

            videopost1.Play();
            Console.WriteLine($"Press any key to stop the video");
            Console.ReadKey();
            videopost1.Stop();
        }
    }
}
