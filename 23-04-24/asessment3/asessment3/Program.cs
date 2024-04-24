using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();

        List<int> numbers = input.Split(' ').Select(int.Parse).ToList();


        Console.WriteLine("Enter the specific value:");
        int specificValue = Convert.ToInt32(Console.ReadLine());

        var result = from number in numbers
                     where number > specificValue
                     select number;

        Console.WriteLine($"Numbers greater than {specificValue}:");
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
}
