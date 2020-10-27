using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the width:");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            

            if (input1 > input2)
            {
                Console.WriteLine("The format of the picture is landscape");
            }
            else
            {
                Console.WriteLine("The format of the picture is portait");
            }
        }
    }
}
