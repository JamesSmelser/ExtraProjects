using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Miller", 40000);

            michael.Work();
            michael.Pause();

            Boss chuck = new Boss("Porsche", "Chuck", "Norris", 120000);
            chuck.Lead();

            Trainee michelle = new Trainee(32, 8, "Michelle", "Gartner", 10000);
            michelle.Learn();
            michelle.Work();
        }
    }
}
