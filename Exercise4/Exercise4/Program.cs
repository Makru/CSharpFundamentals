using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the speedlimit:");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int dif = input1 - input2;

            if (dif < 0)
            {
                dif = dif * -1;
            }

            int points = dif / 5;


            if (input2 < input1)
            {
                Console.WriteLine("The speed is ok.");
            }
            else if (points <= 12)
            {
                Console.WriteLine("You are to fast and will get"+" " + points + " demerit points!");
            }
            else
            {
                Console.WriteLine("License Suspended!!!");
            }
        }
    }
}

