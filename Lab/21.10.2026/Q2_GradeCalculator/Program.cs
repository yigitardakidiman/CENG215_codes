using System;

namespace Q2_GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the two midterm grades and the final grade.
            Console.Write("Enter midterm 1 grade: ");
            double midterm1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter midterm 2 grade: ");
            double midterm2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter final grade: ");
            double final = Convert.ToDouble(Console.ReadLine());

            // 2. Calculate average = midterm1 x 0.20 + midterm2 x 0.20 + final x 0.60.
            double average = midterm1 * 0.20 + midterm2 * 0.20 + final * 0.60;

            // 3. Select "Passed" if average >= 70; otherwise, select "Failed".
            string result = average >= 70 ? "Passed" : "Failed";

            // 4. Display the average and result.
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Result: " + result);
        }
    }
}
