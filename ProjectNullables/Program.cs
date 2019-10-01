﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine($"Our nullable values are {num1}, {num2}, {num3}, {num3}");
            Console.WriteLine($"The nullable boolean value is {boolval}");

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine($"User is male");
            }
            else if(isMale == false)
            {
                Console.WriteLine($"User is female");
            }
            else
                Console.WriteLine($"No gender chosen");

            double? num6 = 13.1;
            double? num7 = null;
            double? num8;

            if(num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = num6;
            }
            Console.WriteLine($"Value of num8 is {num8}");

            num8 = num6 ?? 8.53;
            Console.WriteLine($"Value of num8 is {num8}");
            num8 = num7 ?? 8.53;
            Console.WriteLine($"Value of num8 is {num8}");
        }
    }
}
