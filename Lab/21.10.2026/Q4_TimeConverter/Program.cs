using System;

namespace Q4_TimeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the total number of seconds.
            Console.Write("Enter the total number of seconds: ");
            int totalSeconds = Convert.ToInt32(Console.ReadLine());

            // 2. Calculate hours = totalSeconds / 3600.
            int hours = totalSeconds / 3600;

            // 3. Calculate the remaining seconds using % 3600.
            int remainingSeconds = totalSeconds % 3600;

            // 4. Calculate minutes and seconds from the remainder.
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            // 5. Display hours, minutes, and seconds.
            Console.WriteLine(totalSeconds + " seconds equals " + hours + " hour(s), "
                + minutes + " minute(s) and " + seconds + " second(s).");
        }
    }
}
