using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEmployees
{
    class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss(string companyCar, string firstname, string lastname, decimal salary) : base (firstname,lastname,salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"I am the Boss! My name is {FirstName} {LastName}");
        }
    }
}
