using System;
using System.Collections.Generic;
using System.Linq;

namespace T5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0));

            //--------------
            Console.WriteLine(string.Join(", ", queue));

            //--------------
            //while (queue.Count > 1)
            //{
            //    Console.Write($"{queue.Dequeue()}, ");
            //}

            //Console.Write(queue.Dequeue());
            
            //--------------
            //int[] finalResult = queue.ToArray();
            //Console.WriteLine(String.Join(", ", finalResult));
        }
    }
}
