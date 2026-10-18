using System;

namespace Homework2
{
    internal class AgeCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your current age: ");
            string ageInput = Console.ReadLine();

            int age = Convert.ToInt32(ageInput);

            int nextYearAge = age + 1;

            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Next year, you will be " + nextYearAge + " years old.");
        }
    }
}