using System;
using HelloWorld.Math;
using Conditionals;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void  Main(string[] args)
        {
           var dateTime = new DateTime(2021, 2, 3);
           var now = DateTime.Now;
           var today = DateTime.Today;

           System.Console.WriteLine("dateTime: " + dateTime);
           System.Console.WriteLine("now: " + now);

           System.Console.WriteLine("Hour: " + now.Hour);
           System.Console.WriteLine("Minute: " + now.Minute);

           var tomorrow = now.AddDays(1);
           var yesterday = now.AddDays(-1);

           System.Console.WriteLine(tomorrow);
           System.Console.WriteLine(yesterday);
        }
    }
}
