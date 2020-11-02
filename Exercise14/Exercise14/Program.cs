using System;
using System.Collections.Generic;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte gebe eine Liste mit Zahlen durch Komma getrennt ein:");

                var input = Console.ReadLine();
                var numbers = input.Split(',');
                Console.WriteLine("stringLength of input: " + input.Length);
                Console.WriteLine("stringLength of numbers: " + numbers.Length);
                Console.WriteLine();
                Console.WriteLine("String-Liste:");
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }

                if (input.Length == 0)
                {
                    Console.WriteLine("Bitte erneut versuchen!");
                    continue;
                }

                else
                {


                    var zahlen = new List<int>();
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        var listItem = Convert.ToInt32(numbers[i]);
                        zahlen.Add(listItem);
                    }

                    Console.WriteLine("Int-Liste:");
                    foreach (var zahl in zahlen)
                    {
                        Console.WriteLine(zahl);
                    }
                    zahlen.Sort();
                    Console.WriteLine("Sortierte Liste der 3 kleinsten Zahlen: ");
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine(zahlen[k]);
                    }
                }
                break;
            }
        }
    }
}
