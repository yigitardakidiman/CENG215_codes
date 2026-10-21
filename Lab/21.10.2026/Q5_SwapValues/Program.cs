using System;

namespace Q5_SwapValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read two integers.
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            // 2. Display their original values.
            Console.WriteLine("Before: first = " + first + ", second = " + second);

            // 3. Store the first value in a temporary variable.
            int temp = first;

            // 4. Assign the second value to the first variable.
            first = second;

            // 5. Assign the temporary value to the second variable.
            second = temp;

            // 6. Display the swapped values.
            Console.WriteLine("After: first = " + first + ", second = " + second);
        }
    }
}
