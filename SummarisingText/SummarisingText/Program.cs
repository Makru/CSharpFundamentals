using System;
using System.Collections.Generic;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text.";
            var sentence2 = "This is going to be.";

            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);
            var summary2 = StringUtility.SummerizeText(sentence2, 5);
            Console.WriteLine(summary2);
        }

   
    }
}
