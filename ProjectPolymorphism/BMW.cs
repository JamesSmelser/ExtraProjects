using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolymorphism
{
    class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"Brand:{brand} Model:{Model} HP:{HP} Color:{Color}");
        }
        public override void Repair()
        {
            Console.WriteLine($"The {brand} {Model} was repaired");
        }
    }
}
