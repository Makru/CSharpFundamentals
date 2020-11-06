using System;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one or more English words: ");
            var word = Console.ReadLine();

            Console.WriteLine("The number of vowels is: {0}", GetVowelsCount(word));
        }

        public static int GetVowelsCount(string word)
        {
            int total = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    total++;
                }
            }
            return total;
        }
    }
}
