using System;
using System.IO;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            var path = @"C:\Users\mathi\source\repos\CSharp_Fundamentals\HelloWorld\HelloWorld.sln";

            //ohne Path
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine("Extension: " + extension);
            //mit Path
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));


        }
    }
}
