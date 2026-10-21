using System;

namespace Q1_CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Define PI as a constant.
            const double PI = 3.14159;

            // 2. Read the radius as a double.
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // 3. Calculate area = PI x radius x radius.
            double area = PI * radius * radius;

            // 4. Calculate circumference = 2 x PI x radius.
            double circumference = 2 * PI * radius;

            // 5. Display both results.
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circumference);
        }
    }
}
