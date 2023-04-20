using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10); // Generate an array of 10 numbers
        PrintNumbers(numbers);
        Reverse(numbers); // Reverse the array
        PrintNumbers(numbers); // Print the reversed array
        Console.ReadKey();
    }

    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1; // Populate the array with sequential numbers
        }
        return numbers;
    }

    static void Reverse(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}