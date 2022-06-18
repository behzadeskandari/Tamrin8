using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }

            List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);

            oddNumbers.ForEach(x => Console.WriteLine(x));

        }
    }
}