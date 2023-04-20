//1
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int[] copiedArray = new int[originalArray.Length];

//        for (int i = 0; i < originalArray.Length; i++)
//        {
//            copiedArray[i] = originalArray[i];
//        }

//        Console.WriteLine("Original array:");
//        foreach (int num in originalArray)
//        {
//            Console.Write(num + " ");
//        }

//        Console.WriteLine("\nCopied array:");
//        foreach (int num in copiedArray)
//        {
//            Console.Write(num + " ");
//        }
//    }
//}

//2

//using System;
//using System.Collections.Generic;

//namespace ListManager
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> list = new List<string>();

//            while (true)
//            {
//                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");

//                string input = Console.ReadLine();
//                string action = input.Substring(0,2);
//                string item = input.Substring(2);

//                switch (action)
//                {
//                    case "+ ":
//                        list.Add(item);
//                        break;
//                    case "- ":
//                        list.Remove(item);
//                        break;
//                    case "--":
//                        list.Clear();
//                        break;
//                }

//                Console.WriteLine("Current list:");
//                foreach (string listItem in list)
//                {
//                    Console.WriteLine(listItem);
//                }
//            }
//        }
//    }
//}

//3
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] primes = FindPrimesInRange(1, 100);

//        Console.WriteLine("Prime numbers between 1 and 100:");
//        foreach (int prime in primes)
//        {
//            Console.Write(prime + " ");
//        }

//        Console.ReadLine();
//    }
//    static bool IsPrime(int num)
//    {
//        if (num < 2) return false;

//        for (int i = 2; i <= Math.Sqrt(num); i++)
//        {
//            if (num % i == 0) return false;
//        }

//        return true;
//    }

//    static int[] FindPrimesInRange(int startNum, int endNum)
//    {
//        List<int> primes = new List<int>();

//        for (int i = startNum; i <= endNum; i++)
//        {
//            if (IsPrime(i)) primes.Add(i);
//        }

//        return primes.ToArray();
//    }

//}

//4
//using System;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        // Read the array and k from input
//        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//        int k = int.Parse(Console.ReadLine());

//        // Initialize the sum array
//        int[] sum = new int[array.Length];

//        // Rotate the array k times and calculate the sum after each rotation
//        for (int r = 1; r <= k; r++)
//        {
//            // Rotate the array right by one position
//            int temp = array[array.Length - 1];
//            for (int i = array.Length - 1; i > 0; i--)
//            {
//                array[i] = array[i - 1];
//            }
//            array[0] = temp;

//            // Calculate the sum after this rotation
//            for (int i = 0; i < array.Length; i++)
//            {
//                sum[i] += array[(i + r) % array.Length];
//            }
//        }

//        // Output the sum array
//        for (int i = 0; i < sum.Length; i++)
//        {
//            Console.Write(sum[i] + " ");
//        }
//    }
//}

//5
//using System;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        // Read the input array from the console
//        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//        // Initialize variables to track the longest sequence
//        int maxCount = 0;
//        int maxIndex = 0;

//        // Loop through the array, tracking the current sequence
//        int count = 1;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] == array[i - 1])
//            {
//                count++;
//            }
//            else
//            {
//                if (count > maxCount)
//                {
//                    maxCount = count;
//                    maxIndex = i - count;
//                }
//                count = 1;
//            }
//        }

//        // Check the last sequence
//        if (count > maxCount)
//        {
//            maxCount = count;
//            maxIndex = array.Length - count;
//        }

//        // Output the longest sequence
//        for (int i = maxIndex; i < maxIndex + maxCount; i++)
//        {
//            Console.Write(array[i] + " ");
//        }
//    }
//}

//6
//using System;
//using System.Collections.Generic;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        // Read the input sequence from the console
//        int[] sequence = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//        // Initialize a dictionary to count the frequencies of each number
//        Dictionary<int, int> counts = new Dictionary<int, int>();

//        // Loop through the sequence, counting the frequencies of each number
//        int maxCount = 0;
//        int mostFrequent = sequence[0];
//        for (int i = 0; i < sequence.Length; i++)
//        {
//            int num = sequence[i];
//            if (!counts.ContainsKey(num))
//            {
//                counts[num] = 0;
//            }
//            counts[num]++;
//            if (counts[num] > maxCount || (counts[num] == maxCount && num < mostFrequent))
//            {
//                maxCount = counts[num];
//                mostFrequent = num;
//            }
//        }

//        // Output the most frequent number
//        Console.WriteLine("The number {0} is the most frequent (occurs {1} times)", mostFrequent, maxCount);
//    }
//}

//7
//using System;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        // Read the input string from the console
//        string input = Console.ReadLine();

//        // Convert the string to a char array, reverse it, then convert it back to a string
//        char[] chars = input.ToCharArray();
//        Array.Reverse(chars);
//        string reversed = new string(chars);

//        // Output the reversed string
//        Console.WriteLine(reversed);
//    }
//}

//using System;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        // Read the input string from the console
//        string input = Console.ReadLine();

//        // Print the letters of the string in reverse order
//        for (int i = input.Length - 1; i >= 0; i--)
//        {
//            Console.Write(input[i]);
//        }

//        // Output a newline character to separate from any following text
//        Console.WriteLine();
//    }
//}

//str2
//using System;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        // Read the input sentence from the console
//        string input = Console.ReadLine();

//        // Define the word separators
//        char[] separators = new char[] { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };

//        // Split the sentence into words using the separators
//        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

//        // Reverse the words array
//        Array.Reverse(words);

//        // Build the output string using the original separators
//        string[] parts = input.Split(words, StringSplitOptions.None);
//        string output = "";
//        for (int i = 0; i < parts.Length; i++)
//        {
//            output += parts[i];
//            if (i < words.Length)
//            {
//                output += words[i];
//            }
//        }

//        // Output the reversed sentence
//        Console.WriteLine(output);
//    }
//}

//3
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        // Read the input text from the console
//        string input = Console.ReadLine();

//        // Define the word separators and ignore case when checking for palindromes
//        char[] separators = new char[] { ' ', ',', '.', ':', ';', '!', '?', '\'', '\"' };
//        StringComparison comparison = StringComparison.OrdinalIgnoreCase;

//        // Split the text into words using the separators
//        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

//        // Initialize a set to store the unique palindromes
//        HashSet<string> palindromes = new HashSet<string>();

//        // Loop through the words, checking for palindromes
//        foreach (string word in words)
//        {
//            if (IsPalindrome(word, comparison))
//            {
//                palindromes.Add(word);
//            }
//        }

//        // Sort the palindromes and output them to the console
//        List<string> sortedPalindromes = palindromes.ToList();
//        sortedPalindromes.Sort();
//        Console.WriteLine(string.Join(", ", sortedPalindromes));
//    }

//    // Returns true if the given string is a palindrome (ignoring case)
//    static bool IsPalindrome(string str, StringComparison comparison)
//    {
//        for (int i = 0; i < str.Length / 2; i++)
//        {
//            if (!object.Equals(str[i], str[str.Length - i - 1]))
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//}

//4
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Read the input URL from the console
        string input = Console.ReadLine();

        // Parse the URL into its parts
        string protocol = "";
        string server = "";
        string resource = "";
        int protocolIndex = input.IndexOf("://");
        if (protocolIndex != -1)
        {
            protocol = input.Substring(0, protocolIndex);
            input = input.Substring(protocolIndex + 3);
        }
        int resourceIndex = input.IndexOf("/");
        if (resourceIndex != -1)
        {
            server = input.Substring(0, resourceIndex);
            resource = input.Substring(resourceIndex + 1);
        }
        else
        {
            server = input;
        }

        // Output the parsed parts to the console
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}
