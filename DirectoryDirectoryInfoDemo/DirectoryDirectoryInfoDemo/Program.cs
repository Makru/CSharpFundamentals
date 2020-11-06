using System;
using System.IO;

namespace DirectoryDirectoryInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\temp\folder1");

            //var files = Directory.GetFiles(@"C:\Users\mathi\source\repos\CSharp_Fundamentals", "*.sln",
            //    SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(@"C:\Users\mathi\source\repos\CSharp_Fundamentals", "*.*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists(@"C:\Users\mathi\source\repos\CSharp_Fundamentals");

            var directoryInfo = new DirectoryInfo(@"C:\Users\mathi\source\repos\CSharp_Fundamentals");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
