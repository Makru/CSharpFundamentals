using System;
using System.Collections.Generic;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte enter einige Ziffern mit Bindestrich getrennt: ");
            var input = Console.ReadLine();
            
            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }
    }
}
