using System;

namespace Homework2
{
    internal class RectangleCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
