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
           var name = "Kenneth Colon ";
           System.Console.WriteLine("Trim & Uppercase: " + name.Trim().ToUpper());

           var nameSplit = name.Split(' ');
           System.Console.WriteLine("First Name: " + nameSplit[0]);
           System.Console.WriteLine("Last Name: " + nameSplit[1]);

           System.Console.WriteLine(name.Replace("Kenneth", "Ken"));

           if(String.IsNullOrWhiteSpace(" "))
           System.Console.WriteLine("INVALID");
        }
    }
}
