using System;
using System.Collections.Generic;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte enter einige Ziffern mit Bindestrich getrennt:");
            var input = Console.ReadLine();

            Console.WriteLine(CheckConsecutivity(input));
        }

        public static string CheckConsecutivity(string input)
        {
            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            return message;
        }
    }
}

