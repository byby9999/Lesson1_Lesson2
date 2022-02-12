using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Here is my branch");

            int x = 10;

            //Aici este un comentariu

            // x = x * 2

            x = x * 2 /* inmultire cu 2*/ + 10;

            /* x = x + 10
             x = x * 4 - 3;*/

            Console.WriteLine(x);

            Console.WriteLine("Am primit argumentul de linie de comanda: " + args[0]);
            Console.WriteLine("Am primit argumentul de linie de comanda: " + args[1]);

            Console.ReadKey();

        }
    }
}

namespace MyNameSpace 
{
    namespace Child 
    {
        class Test { }
    }
    class Program { }
}