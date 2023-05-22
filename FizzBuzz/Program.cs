using FizzBuzz;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        FizzBuzz.FizzBuzz.Solve(3).ToList().ForEach(i => Console.Write("{0} ", i));
        Console.WriteLine();
        FizzBuzz.FizzBuzz.Solve(5).ToList().ForEach(i => Console.Write("{0} ", i));
        Console.WriteLine();
        FizzBuzz.FizzBuzz.Solve(15).ToList().ForEach(i => Console.Write("{0} ", i));
    }
}