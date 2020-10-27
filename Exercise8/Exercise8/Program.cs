using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            int x;
            int i = 0;
            var random = new Random();
            //Console.WriteLine(random.Next(1, 10));
            z = random.Next(1, 10);
            while (i <= 3)
            {
                Console.Write("Schätze eine Zahl zwischen 1 und 10: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == z)
                {
                    Console.WriteLine("Richtig geraten! Die Zufallszahl war " + z);
                    break;
                }
                else
                {
                    i++;
                }
            }


        }
    }
}
