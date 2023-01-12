using System;
using System.Collections.Generic;

namespace T7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            int n = int.Parse(Console.ReadLine());

            int tosses = 0;

            while (queue.Count > 1)
            {
                tosses++;
                string name = queue.Dequeue();
                
                if (tosses < n)
                {
                    queue.Enqueue(name);
                }
                else
                {
                    Console.WriteLine($"Removed {name}");
                    tosses = 0;
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
