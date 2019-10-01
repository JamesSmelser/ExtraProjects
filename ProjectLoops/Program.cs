using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int testgrade = 0;
            int testaverage = 0;
            do
            {
                Console.WriteLine($"Previous grade entry was {testgrade}.");
                Console.WriteLine($"Number of grade entries is {counter}");
                Console.Write($"Enter your test grade. [press -1 to calculate average]: ");
                bool parsed = int.TryParse(Console.ReadLine(), out testgrade);
                Console.WriteLine($"\n");

                if (parsed == false)
                {
                    Console.WriteLine($"Incorrect format please enter an integer between 0 - 100!");
                }
                else if (testgrade != -1 && testgrade >= 0 && testgrade <= 100)
                {
                    testaverage += testgrade;
                    counter++;
                }
                else
                    Console.WriteLine($"Incorrect format please enter an integer between 0 - 100!");
            }
            while (testgrade != -1);
            Console.WriteLine($"The grade average is {(double)testaverage / counter}.");
        }
    }
}
