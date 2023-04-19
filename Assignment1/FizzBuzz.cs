using System;

namespace CountingByIncrements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count by 1s
            for (int i = 0; i <= 24; i++)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            // Count by 2s
            for (int i = 0; i <= 24; i += 2)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            // Count by 3s
            for (int i = 0; i <= 24; i += 3)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            // Count by 4s
            for (int i = 0; i <= 24; i += 4)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
