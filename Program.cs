using System;
using System.Linq;

namespace laba3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = rand.Next(-100,100);
                Console.Write("{0,4}", numbers[i]);
            }
            Console.WriteLine();
            Console.Write("Enter the number ");
            int variable = int.Parse(Console.ReadLine());
            var selectedNumbers = from x in numbers
                                  where x % 10 == variable && x > 0
                                  select x;
            variable = (selectedNumbers.Count() > 0) ? selectedNumbers.FirstOrDefault() : 0;
            Console.WriteLine($"Your number is {variable}");
        }
    }
}
