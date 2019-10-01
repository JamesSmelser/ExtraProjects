using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] test = new string[][]
            {
                new string[] {"Bill", "Jane"},
                new string[] {"Bob", "Julia"},
                new string[] {"James", "Christina"}
            };
            for (int i = 0; i < test.Length; i++)
                for (int j = 0; j < test[i].Length; j++)
                    for (int t = test.Length - 1; t > 0; t--)
                        for (int s = test[t].Length - 1; s > 0; s--)
                            Console.WriteLine($"Hello my name is {test[i][j]} nice to meet you {test[t][s]}");

            int[] happiness = { 1, 2, 3, 4, 5, };
            SunIsShining(happiness);
            foreach (int value in happiness)
            {
                Console.WriteLine(value);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(25);
            arrayList.Add(13);
            arrayList.Add(15.89);
            arrayList.Add(19.02);
            arrayList.Add(54);
            arrayList.Add("Taco cat");

            arrayList.Remove(13);
            arrayList.RemoveAt(0);

            Console.WriteLine(arrayList.Count);

            double sum = 0;

            foreach (object obj in arrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);

        }
        public static void SunIsShining(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }
    }
}
