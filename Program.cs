using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Calculate Z = 4X^2 + 3Y where X = 2.5, Y = 3.3
            double X = 2.5;
            double Y = 3.3;

            // Calculate Z
            double Z = 4 * X * X + 3 * Y;

            // Print the result in formatted output
            Console.WriteLine($"For X = {X}, Y = {Y}, the value of Z = {Z:F2}");
        }
    }
}

