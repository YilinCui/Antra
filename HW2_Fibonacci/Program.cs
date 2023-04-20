using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Fibonacci(" + i + ") = " + Fibonacci(i));
        }
        Console.ReadKey();
    }

    static int Fibonacci(int n)
    {
        if (n <= 2)
        {
            return 1;
        }

        int[] fibArray = new int[n];
        fibArray[0] = 1;
        fibArray[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
        }

        return fibArray[n - 1];
    }
}
