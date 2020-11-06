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

            Console.WriteLine(PascalCaseConverter(input));
        }

        public static StringBuilder PascalCaseConverter(string input)
        {
            var inputNew = input.Split(" ");
            var output = new StringBuilder();
            foreach (var word in inputNew)
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                output.Append(wordWithPascalCase);
            }

            return output;
        }
    }
}

