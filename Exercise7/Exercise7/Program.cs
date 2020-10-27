using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            Console.Write("Dieses Programm berechnet die Fakultät von x. Bitte gebe einen Wert für x ein:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("x = " + x);

            for (int i = 1; i <= x; i++)
            {
                y *= i;
                //y = y * i;
            }

            Console.WriteLine("Die Fakultät von x = " + y);
        }
    }
}

