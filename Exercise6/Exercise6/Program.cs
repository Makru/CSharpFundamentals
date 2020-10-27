using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input;
            int sum=0;
            while (true)
            {
                Console.Write("Write a number or type ok to leave: ");
                var input = Console.ReadLine();
                if (input != "ok")
                {
                    int inputNew;
                    inputNew = Convert.ToInt32(input);
                    Console.WriteLine("Number: " + inputNew);
                    sum = sum + inputNew;
                    Console.WriteLine("Die Summe der bisher eingegebenen Zahle ist:"+sum);
                    continue;
                }
                break;
            }
        }
    }
}
