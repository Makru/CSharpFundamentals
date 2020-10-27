using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte enter einige Zahlen mit Komma getrennt:");


            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var nr in numbers)
            {
                var number = Convert.ToInt32(nr);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }
    }
}