using System;
using System.Threading.Channels;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand this season!");
                    break;
            }
        }
    }
}
