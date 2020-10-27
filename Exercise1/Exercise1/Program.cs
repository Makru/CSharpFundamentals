using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            Console.WriteLine("Enter a Number:");
            int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You entered:" + " " + input);
            
            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("This ist valid!");
            }
            else
            {
                Console.WriteLine("This is invalid");
            }
        }
    }
}
