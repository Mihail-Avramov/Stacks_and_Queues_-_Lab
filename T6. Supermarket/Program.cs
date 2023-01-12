using System;
using System.Collections.Generic;

namespace T6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> queue = new Queue<String>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
