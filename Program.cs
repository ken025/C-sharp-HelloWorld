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
        
        
        int k = 1;
        int m = k++;

        System.Console.WriteLine(k);
        System.Console.WriteLine(m);

        int k2 = 1;
        int m2 = ++k2;

        System.Console.WriteLine(k2);
        System.Console.WriteLine(m2);

        var numb = 1;
        var numbe = 2;
        var nmbr = 3; 

        System.Console.WriteLine(!(nmbr > numbe || nmbr == numb));
        }
    }
}
