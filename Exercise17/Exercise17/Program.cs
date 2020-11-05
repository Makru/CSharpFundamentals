using System;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gebe eine Uhrzeit im 24h-Format ein, (z.B.19:00): ");

            var input = Console.ReadLine();
            var outut = "Invalid Time!";

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(outut);
                return;
            }

            var timeComponents = input.Split(':');
            if (timeComponents.Length != 2)
            {
                Console.WriteLine(outut);
                return;
            }

            try
            {
                var hour = Convert.ToInt32(timeComponents[0]);
                var minute = Convert.ToInt32(timeComponents[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok!");
                else
                    Console.WriteLine(outut);
            }
            catch (Exception)
            {
                Console.WriteLine(outut);
            }

        }
    }
}
