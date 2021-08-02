using System;
using System.Diagnostics;
using System.Linq;
using HailNumber;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type \"quit\" to exit.");
                Console.Write("Enter a positive integer: ");
                var raw = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(raw))
                    continue;
                if (raw.ToLower() == "quit")
                    return;
                if (long.TryParse(raw, out var numericValue))
                {
                    if (numericValue >= 1)
                    {
                        var stop = new Stopwatch();
                        stop.Start();
                        var hail = HailCalculator.CalculateHailNumber(numericValue);
                        stop.Stop();
                        Console.WriteLine($"The value {numericValue} has a hail number of {hail.Value}.");
                        Console.WriteLine($"The hail number was calculated in {stop.ElapsedMilliseconds} milliseconds with {hail.Hops.Count} hops.");
                        Console.WriteLine($"Hops: {string.Join(", ", hail.Hops)}");
                        Console.WriteLine($"Max hop value: {hail.Hops.Max()}");
                    }
                    else
                        Console.WriteLine("Supplied value is less than 1. Please enter a value greater than 1.");
                }
            }
        }
    }
}
