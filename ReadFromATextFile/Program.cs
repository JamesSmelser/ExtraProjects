using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFromATextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringLines = { "Technology made large populations possible;", "large populations now make technology indispensable.", "- Joseph Krutch" };

            File.WriteAllLines(@"C:\Users\smels\OneDrive\Desktop\textfile.txt", stringLines);

            string text = File.ReadAllText(@"C:\Users\smels\OneDrive\Desktop\textfile.txt");

            Console.WriteLine($"textfile contains the following text: {text}");

            string[] lines = File.ReadAllLines(@"C:\Users\smels\OneDrive\Desktop\textfile.txt");

            Console.WriteLine($"Contents of textfile.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine($"Enter the file name");
            string fileName = Console.ReadLine();
            Console.WriteLine($"\nEnter your text");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\smels\OneDrive\Desktop\" + fileName + ".txt", input);

            using (StreamWriter filer = new StreamWriter(@"C:\Users\smels\OneDrive\Desktop\textfile.txt", true))
            {
                filer.WriteLine($"Additional text line");
            }

            using (StreamWriter filed = new StreamWriter(@"C:\Users\smels\OneDrive\Desktop\mytext2.txt"))
            {
                foreach(string line in lines)
                {
                    if(line.Contains("populations"))
                    {
                        filed.WriteLine(line);
                    }
                }
            }
        }
    }
}
