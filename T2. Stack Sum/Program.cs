using System;
using System.Collections.Generic;
using System.Linq;

namespace T2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            string input;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] commandArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArg[0];

                if (command == "add")
                {
                    int firstNumber = int.Parse(commandArg[1]);
                    int secondNumber = int.Parse(commandArg[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                    continue;
                }
                
                if (command == "remove")
                {
                    int count = int.Parse(commandArg[1]);

                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                    continue;
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}
