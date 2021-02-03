using System;
using HelloWorld.Math;
using Conditionals;

namespace HelloWorld
{
    class Program
    {
        static void  Main(string[] args)
        {
          for( var i = 1; i <= 10; i++){
              if (i%2 == 0){
                  System.Console.WriteLine(i);
              }
          }

          var name = "Kenneth";

          for (var i = 0; i < name.Length; i++){
              System.Console.WriteLine(name[i]);
          }

          foreach(var character in name){
              System.Console.WriteLine(character);
          }

         }
    }
}
