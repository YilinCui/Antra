using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sbyte: {0} bytes, min: {1}, max: {2}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("byte: {0} bytes, min: {1}, max: {2}", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("short: {0} bytes, min: {1}, max: {2}", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("ushort: {0} bytes, min: {1}, max: {2}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int: {0} bytes, min: {1}, max: {2}", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("uint: {0} bytes, min: {1}, max: {2}", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("long: {0} bytes, min: {1}, max: {2}", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("ulong: {0} bytes, min: {1}, max: {2}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("float: {0} bytes, min: {1}, max: {2}", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("double: {0} bytes, min: {1}, max: {2}", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("decimal: {0} bytes, min: {1}, max: {2}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

            Console.ReadKey();
        }
    }
}
