
using System.Diagnostics;

namespace assignment5
{
    internal class Program
    {
        static long Factorial(int number)
        {
            if (number == 1)
                return 1;
            return number * Factorial(number - 1);
        }

        static int Fibonacci(int number)
        {
            if (number == 0 || number == 1)
                return number;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        static async Task<int> fib(int number)
        {
            return await Task.Run(() => Fibonacci(number));
        }
        static async Task<long> fact(int number)
        {
            return await Task.Run(() => Factorial(number));
        }
        static async Task Main(string[] args)
        {
                 
            int fibonacci = await Task.Run(() => (fib(20)));
            long factorial = await Task.Run(() => (fact(20)));
            Console.WriteLine($"20th Fabonacci No : {fibonacci}");
            Console.WriteLine($"Factorial of 20 : {factorial}");


        }
    }
}