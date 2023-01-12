using System;
using System.Collections.Generic;

namespace T8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int sum = 0;
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }

                        sum++;
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{sum} cars passed the crossroads.");
        }
    }
}
