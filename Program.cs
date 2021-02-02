using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void  Main(string[] args)
        {
            var ken = new Person();
            ken.FirstName = "Ken";
            ken.LastName = "Colon";
            ken.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}