using System;
using System.IO;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var path = @"C:\Users\mathi\source\repos\Exercise20\myfile.txt";
            var content = File.ReadAllText(path);
            var count = (content.Split(" ")).Length;

            Console.WriteLine(content);
            Console.WriteLine("Die Anzahl der Wörter in myfile.txt ist: " + count);

            string word = "";
            int ctr = 0;
            foreach (String str in (content.Split(" ")))
            {
                if (str.Length > ctr)
                {
                    word = str;
                    ctr = str.Length;
                }
            }

            Console.WriteLine("Das längste Wort in myfile.txt ist: "+ word);

        }
    }
}
