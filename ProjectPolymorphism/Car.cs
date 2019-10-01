using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        protected CarIDInfo carIDInfo = new CarIDInfo();
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP:{HP} Color:{Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine($"Car was repaired");
        }
    }
}
