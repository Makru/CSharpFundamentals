using System;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            
            Console.WriteLine("timeSpan:" + timeSpan);
            Console.WriteLine("timeSpan1: " + timeSpan1);

            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("timeSpan2: " + timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Dauer: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add - Substract
            Console.WriteLine("Add Example: " +timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Substract Example: " +timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // To String
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
