using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte enter einige Ziffern mit Bindestrich getrennt: ");
            var input = Console.ReadLine();

            Console.WriteLine(CheckForDuplicates(input));
        }

        public static string CheckForDuplicates(string input)
        {
            var output="Invalid Input!";

            if (String.IsNullOrWhiteSpace(input))
            {
                return output;
            }

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
                output = "Duplicate";
            return output;
        }
    }
}

