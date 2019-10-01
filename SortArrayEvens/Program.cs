using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 3, 4, 5, 6, 7, 9, 10, 11 };

            SortEvens(intArray);
        }
        public static void SortEvens(int[] array)
        {
            int acc = array.Length;
            int inc = 0;

            int[] tempArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    tempArray[inc] = array[i];
                    ++inc;
                }
                else if (array[i] % 2 == 1)
                {
                    tempArray[acc - 1] = array[i];
                    --acc;
                }
            }
            Array.ForEach(tempArray, Console.WriteLine);
        }
    }
}
