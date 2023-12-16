using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FunctionCache<string, int> cache = new FunctionCache<string, int>(StringLengthFunction);

            string input = "Hello!";
            TimeSpan cacheDuration = TimeSpan.FromMinutes(1);

            int result1 = cache.GetResult(input, cacheDuration);
            Console.WriteLine($"Result 1: {result1}");

        
            System.Threading.Thread.Sleep(2000);

            int result2 = cache.GetResult(input, cacheDuration);
            Console.WriteLine($"Result 2: {result2}");
        }

        static int StringLengthFunction(string input)
        {
            Console.WriteLine("Executing function...");
            return input.Length;
        }
        }
    }
