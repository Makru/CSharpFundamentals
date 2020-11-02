using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Execise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Write your name or enter to leave: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    names.Add(input);
                    continue;
                }

                Console.WriteLine("Die Liste enthält: " + names.Count + " Namen.");
                Console.WriteLine();


                if (names.Count == 1)
                    Console.WriteLine(names[0] + " mag deinen Post.");
                
                else if (names.Count == 2)
                    Console.WriteLine(names[0]+ " und " + names[1] + " mögen deinen Post.");

                else if (names.Count > 2)
                    Console.WriteLine(names[0] + ", " + names[2] + " und " + (names.Count-2) +" weitere mögen deinen Post.");

                //foreach (var name in names)
                //    Console.WriteLine((name));
                break;
            }
        }
    }
}
