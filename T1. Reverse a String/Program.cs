
using System.Diagnostics;

string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();

Console.WriteLine("------------------------------------------------");

Stopwatch stopwatch = Stopwatch.StartNew();

if (!string.IsNullOrEmpty(input))
{
    foreach (var ch in input)
    {
        stack.Push(ch);
    }

    while (stack.Count > 0)
    {
        Console.Write(stack.Pop());
    }
}

stopwatch.Stop();
Console.WriteLine();
Console.WriteLine(stopwatch.ElapsedMilliseconds);

Console.WriteLine("------------------------------------------------");
stopwatch.Restart();

if (!string.IsNullOrEmpty(input))
{
    stack = new Stack<char>(input);

    Console.WriteLine(string.Join("", stack));
}

stopwatch.Stop();
Console.WriteLine();
Console.WriteLine(stopwatch.ElapsedMilliseconds);