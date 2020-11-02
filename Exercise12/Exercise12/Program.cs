using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            var zahlen = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                int count = i + 1;
                Console.WriteLine("Bitte enter die " + count + ". von 5 Zahlen: ");
                string input = (Console.ReadLine());
                if (zahlen.Contains(Convert.ToInt32(input)))
                {
                    Console.WriteLine("Bitte diese Zahl nocheinmal eingeben. Doppelte Zahlen sind nicht erlaubt.");
                    Array.Clear(zahlen, i, 1);
                    i--;
                }
                if (!String.IsNullOrWhiteSpace(input))
                {
                    zahlen[i] = Convert.ToInt32(input);
                }
            }
            Array.Sort(zahlen);
            foreach (var zahl in zahlen)
            {
                Console.WriteLine();
                Console.WriteLine(zahl);
            }
        }
    }
}
