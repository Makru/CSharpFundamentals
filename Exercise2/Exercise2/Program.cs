using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number:");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another Number:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You entered:" + " " + input);

            if (input1 > input2)
            {
                Console.WriteLine("This is the bigger number:"+" "+ input1);
            }
            else
            {
                Console.WriteLine("This is the bigger number: "+ " "+ input2);
            }
        }
    }
}
