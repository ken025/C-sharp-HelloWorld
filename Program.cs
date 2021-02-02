using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
         int i = 1;
         float f = i;

        Console.WriteLine(i);
        Console.WriteLine(f);

        int a = 2;
        byte b = (byte) a;

        Console.WriteLine(b);

        var number = "123";
        int n = Convert.ToInt32(number);

        System.Console.WriteLine(n);

        try
        {
            var num = "1234";
            byte s  = Convert.ToByte(num);
            System.Console.WriteLine(s);
        
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("The number cannot be converted into a byte");
        }
        
        }
    }
}
