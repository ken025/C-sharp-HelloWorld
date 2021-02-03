using System;
using HelloWorld.Math;
using Conditionals;

namespace HelloWorld
{
    class Program
    {
        static void  Main(string[] args)
        {
            var numbers = new[] {1, 2, 3, 4, 5};

            // length 
            System.Console.WriteLine("Lenght of array: ", + numbers.Length);

            // find position
            var indx = Array.IndexOf(numbers, 2);
            System.Console.WriteLine(indx);

            // //clear    (array, starting index, lenght to be cleared)
            Array.Clear(numbers, 0, 2);

            System.Console.WriteLine("Effect of C;ear()");
            foreach(var n in numbers)
            System.Console.WriteLine(n);

            //copy 
            int[] another = new int[3];   
            // (array, destination, number of elements to be copied)
            Array.Copy(numbers, another, 3);

System.Console.WriteLine("Effect of Copy()");
            foreach(var n in another)
            System.Console.WriteLine(n);

            //sort 
            Array.Sort(numbers);
            foreach(var n in numbers)
            System.Console.WriteLine(n);

            //reverse
            Array.Reverse(numbers);
            foreach(var n in numbers)
            System.Console.WriteLine(n);
        }
    }
}
