using System;

namespace Homework2
{
    internal class NumberOperations
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double division = (double)num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Division: " + division);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
