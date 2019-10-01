using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructs
{
    struct Game
    {
        public string Name;
        public string Developer;
        public double Rating;
        public string ReleaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.Name = name;
            this.Developer = developer;
            this.Rating = rating;
            this.ReleaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine($"Game 1's name is: {Name}");
            Console.WriteLine($"Game 1 was developed by: {Developer}");
            Console.WriteLine($"Game 1's rating is: {Rating}");
            Console.WriteLine($"Game 1 was released in: {ReleaseDate}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game1;

            game1.Name = "Pokemon Go";
            game1.Developer = "Niantic";
            game1.Rating = 3.5;
            game1.ReleaseDate = "01.07.2016";

            game1.Display();
        }
    }
}
