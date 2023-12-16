using System;
using System.Collections.Generic;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Repository<int> intRepository = new Repository<int>();
            intRepository.Add(1);
            intRepository.Add(2);
            intRepository.Add(3);
            intRepository.Add(4);

            
            Criteria<int> isEven = x => x % 2 == 0;

            List<int> evenNumbers = intRepository.Find(isEven);
            Console.WriteLine("Парні числа:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Repository<string> stringRepository = new Repository<string>();
            stringRepository.Add("apple");
            stringRepository.Add("banana");
            stringRepository.Add("orange");

            
            Criteria<string> startsWithA = s => s.StartsWith("a", StringComparison.OrdinalIgnoreCase);

            List<string> aWords = stringRepository.Find(startsWithA);
            Console.WriteLine("Слова, що починаються з 'a':");
            foreach (string word in aWords)
            {
                Console.WriteLine(word);
            }
        }
    }

    
}