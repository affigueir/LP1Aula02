using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 5;

            int c = a++ + ++b;

            //Console.WriteLine(c);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            Console.WriteLine($"{a} {b} {c}");  

        }
    }
}
