//using System;

//namespace CenturyConverter
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Get input from user
//            Console.Write("Enter number of centuries: ");
//            int centuries = int.Parse(Console.ReadLine());

//            // Convert centuries to years, days, hours, minutes, seconds, milliseconds, microseconds, and nanoseconds
//            long years = centuries * 100;
//            long days = years * 365 + years / 4;
//            long hours = days * 24;
//            long minutes = hours * 60;
//            long seconds = minutes * 60;
//            long milliseconds = seconds * 1000;
//            long microseconds = milliseconds * 1000;
//            long nanoseconds = microseconds * 1000;

//            // Output results
//            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
//                centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);

//            Console.ReadKey();
//        }
//    }
//}
