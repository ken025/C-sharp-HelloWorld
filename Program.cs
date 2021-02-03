using System;
using HelloWorld.Math;
using Conditionals;

namespace HelloWorld
{
    class Program
    {
        static void  Main(string[] args)
        {
            int hour = 10;

            if (hour > 8 && hour < 12)
            {
            System.Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
            System.Console.WriteLine("It's evening");
            }
            else 
            {
                System.Console.WriteLine("It's afternoon");
            }

            bool isCostumer = true;

            // float price;
            // if (isCostumer)
            //     price = 19.95f;
            // else 
            //     price = 29.95f;

            float price = (isCostumer) ? 19.95f : 29.95f;

            System.Console.WriteLine(price);


            var season = Season.Autumn; 

            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("It's Autumn!");
                break;

                case Season.Summer:
                    System.Console.WriteLine("It's Summer");
                break;

                default:
                    System.Console.WriteLine("I'm not sure");
                break;
            }

         }
    }
}
