using System;
using static System.Array;

namespace Execise11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            //Array.Reverse(array);
            //var reversed1 = new string(array);
            //Console.WriteLine(reversed1);

            var reversed = new string(array);
            Array.Reverse(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
