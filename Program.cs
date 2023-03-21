// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(x + y + z);

            int myNum = 15;
            myNum = 20; 
            Console.WriteLine(myNum);

            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
        }
    }
}
