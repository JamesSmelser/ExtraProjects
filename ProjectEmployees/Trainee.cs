using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEmployees
{
    class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string firstname, string lastname, decimal salary): base (firstname, lastname, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"I am learning for {SchoolHours} hours");
        }

        public override void Work()
        {
            Console.WriteLine($"I work for {WorkingHours} hours");
        }
    }
}
