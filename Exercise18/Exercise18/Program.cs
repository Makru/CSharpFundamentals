using System;
using System.Text;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte enter einige Wörter mit Leerzeichen getrennt:");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalider Input!");
                return;
            }

            var inputNew = input.Split(" ");
            var output = new StringBuilder();

            //Console.WriteLine(input.Length);
            //Console.WriteLine(inputNew.Length);

            foreach (var word in inputNew)
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                output.Insert(0,wordWithPascalCase);
            }

            Console.WriteLine(output);
        }
    }
}
