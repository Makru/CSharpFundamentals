using System;
using System.IO;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var path = @"C:\Users\mathi\source\repos\Exercise20\myfile.txt";
            var content = File.ReadAllText(path);
            var count = (content.Split(" ")).Length;
            
            Console.WriteLine(content);
            Console.WriteLine("Die Anzahl der Wörter in myfile.txt ist: " + count);

        }
    }
}
