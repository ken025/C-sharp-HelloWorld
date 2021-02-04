using System;
using HelloWorld.Math;
using Conditionals;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void  Main(string[] args)
        {

            var builder = new StringBuilder();

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)

                .Replace('-', '~')
                .Remove(0, 10)
                .Insert(0,new string('-', 10));

            System.Console.WriteLine(builder);

System.Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            System.Console.WriteLine($"Hello, my name is: {name}!");
        }
    }
}
