using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .AppendLine("Header")
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("Erster Buchstabe:" + builder[0]);

        }
    }
}
