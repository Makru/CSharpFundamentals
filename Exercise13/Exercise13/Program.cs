using System;
using System.Collections.Generic;

namespace Exercise13
{
    class Program
    {

        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Bitte enter eine Nummer oder enter Quit zum Beenden!");
                var input = Console.ReadLine();

                if (input != "Quit")
                {
                    numbers.Add(Convert.ToInt32(input));
                    continue;
                }

                break;

            }
            //Gibt die gesamte Liste aus
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Gibt ein neue Liste mit den "unique" Zahlen aus der vorherigen Liste aus
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }
    }
}
