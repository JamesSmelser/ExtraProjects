using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectListsArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(32);
            list.ForEach(i => Console.WriteLine(i));
            list.Sort();
            list.ForEach(i => Console.WriteLine(i));
            list.RemoveRange(2, 2);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);

            list.ForEach(i => Console.WriteLine(i));

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });

            foreach(Object o in arrayList)
            {
                Console.WriteLine(o);
            }
        }
    }
    public class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
