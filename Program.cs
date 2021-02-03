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
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var i in numbers)
            System.Console.WriteLine(i);

            System.Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            System.Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            System.Console.WriteLine("Count: " + numbers.Count);

            numbers.Remove(1);
                       foreach (var i in numbers)
            System.Console.WriteLine(i);
        }
    }
}
