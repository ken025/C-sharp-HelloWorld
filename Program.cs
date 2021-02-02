using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void  Main(string[] args)
        {
// literal
         var firstName = "Ken";
         var lastName = "Colon";

// combination
         var fullName = firstName + " " + lastName;
         System.Console.WriteLine(fullName);

//Format
         var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
         System.Console.WriteLine(myFullName);

//Join
         var names = new string[3] {"John", "Jack", "Mary"};
         var formattedNames = string.Join(",", names);
         System.Console.WriteLine(formattedNames);

//Verbatim 
        var text = "Hi John\nLook into the following\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
        System.Console.WriteLine(text);

        var text1 = @"Hi John
        Look into the following
        c:\folder1\folder2
        c:\folder3\folder4";
        System.Console.WriteLine(text1);
        }
    }
}