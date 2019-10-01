using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
    public interface INotification
    {
        void ShowNotification();
        string GetDate();
    }

    public class Notification : INotification
    {
        private string sender;
        private string message;
        private string date;

        public Notification()
        {
            sender = "Admin";
            message = "Hello";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public void ShowNotification()
        {
            Console.WriteLine($"Message [{message}] - was sent by {sender} - at {date}");
        }

        public string GetDate()
        {
            return date;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("James", "Good Morning", "09.10.2019");
            Notification n2 = new Notification("Christina", "Thank you", "09.10.2019");
            n1.ShowNotification();
            n2.ShowNotification();
        }
    }
}
