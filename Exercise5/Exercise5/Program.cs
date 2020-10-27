using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int i = 0;
            do
            {
                i++;
                int k = i % 3;
                if (k == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            } while (i <= 100);
            Console.WriteLine("Die Anzahl der durch 3 teilbaren Zahlen zwischen 1 und 100: " + count);
        }
    }
}
