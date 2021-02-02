using System;

namespace HelloWorld
{
 public class Person
 {
     public string FirstName;
     public string LastName;

     public void Introduce(){
         System.Console.WriteLine("My name is " + FirstName + " " + LastName);
     }
 }

 class Program
 {
     static void  Main(string[] args)
     {
         var ken = new Person();
         ken.FirstName = "Ken";
         ken.LastName = "Colon";
         ken.Introduce();
     }
 }
}
