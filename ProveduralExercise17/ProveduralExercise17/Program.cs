using System;
using System.Reflection.Metadata.Ecma335;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gebe eine Uhrzeit im 24h-Format ein, (z.B.19:00): ");

            var input = Console.ReadLine();
            var output = "Invalid Time!";

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(output);
                return;
            }

            var timeComponents = input.Split(':');
            if (timeComponents.Length != 2)
            {
                Console.WriteLine(output);
                return;
            }

            try
            {
                Console.WriteLine(CheckTimeRange(input));
               
            }
            catch (Exception)
            {
                Console.WriteLine(output);
            }

        }

        public static string CheckTimeRange(string input)
        {
            var timeComponents = input.Split(':');
            var output = "Invalid Time!";

            {
                var hour = Convert.ToInt32(timeComponents[0]);
                var minute = Convert.ToInt32(timeComponents[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                   output = "Ok!";
            }
            return output;
        }

    }
}