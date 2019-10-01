using System;

namespace ProjectFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = { "Sean", "Adam", "Greg", "Mo", "Joe" } ;

            for (int i = 0; i <= friends.Length - 1; i++)
            {
                Console.WriteLine($"Friend {i} is {friends[2]}");
            }
            foreach(string friend in friends)
                Console.WriteLine($"My friend is {friend}");
        }
    }
}
