using System;
using System.Collections.Generic;

namespace T4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> openBracketsIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracketsIndexes.Push(i);
                    continue;
                }

                if (input[i] == ')')
                {
                    int bracketIndex = openBracketsIndexes.Pop();

                    Console.WriteLine(input.Substring(bracketIndex, i - bracketIndex + 1));
                }
            }
        }
    }
}
