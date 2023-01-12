using System;
using System.Collections.Generic;
using System.Linq;

namespace T3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Stack<string> reverseStack = new Stack<string>();

            while (stack.Count > 0)
            {
                string currentString = stack.Pop();
                reverseStack.Push(currentString);
            }

            while (reverseStack.Count > 2)
            {
                int firstNum = int.Parse(reverseStack.Pop());
                string operand = reverseStack.Pop();
                int secondNum = int.Parse(reverseStack.Pop());

                if (operand == "+")
                {
                    int sum = firstNum + secondNum;
                    reverseStack.Push(sum.ToString());
                }
                else if (operand == "-")
                {
                    int sum = firstNum - secondNum;
                    reverseStack.Push(sum.ToString());
                }
            }

            Console.WriteLine(reverseStack.Pop());
        }
    }
}
