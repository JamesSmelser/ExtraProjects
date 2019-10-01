using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEmployees
{
    class Employee
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected decimal Salary { get; set; }

        public Employee()
        {
            FirstName = "James";
            LastName = "Smelser";
            Salary = 60000M;
        }

        public Employee(string firstname, string lastname, decimal salary)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{this.FirstName} is working");
        }

        public void Pause()
        {
            Console.WriteLine($"I am taking a break");
        }
    }
}
