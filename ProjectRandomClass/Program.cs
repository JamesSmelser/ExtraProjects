using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;
            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }

            string input = " ";
            do
            {
                Console.WriteLine($"Ask the Great Fortuna your question to get your answer");
                input = Console.ReadLine();
                Random Fortune = new Random();
                int answer;
                answer = Fortune.Next(1, 4);
                if (answer == 1)
                {
                    Console.WriteLine($"The answer to your question is Yes!");
                }
                else if (answer == 2)
                {
                    Console.WriteLine($"The answer to your question is No!");
                }
                else { Console.WriteLine($"The answer to your question is Maybe!"); }
            }
            while (input != "Leave");
        }
    }
}
