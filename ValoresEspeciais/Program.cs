using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("int values:");
            //Console.WriteLine($"{int.MinValue}");
            //Console.WriteLine($"{int.MaxValue}");
            //
            //Console.WriteLine("float values:");
            //Console.WriteLine($"{float.MinValue}");
            //Console.WriteLine($"{float.MaxValue}");
            //
            //Console.WriteLine("double values:");
            //Console.WriteLine($"{double.MinValue}");
            //Console.WriteLine($"{double.MaxValue}");
            //
            //Console.WriteLine("long values:");
            //Console.WriteLine($"{long.MaxValue}");
            //Console.WriteLine($"{long.MaxValue}");
//
 //
            //Console.WriteLine("float Infinity:");
            //Console.WriteLine($"{float.NegativeInfinity}");
            //Console.WriteLine($"{float.PositiveInfinity}");
            //
            //Console.WriteLine("double Infinity:");
            //Console.WriteLine($"{double.NegativeInfinity}");
            //Console.WriteLine($"{double.PositiveInfinity}");
            
            int ovint = int.MaxValue;
            float ovfloat = float.MaxValue;
            double ovdouble = double.MaxValue;
            long ovlong = long.MaxValue;

            float unfloat = 100000000000000;
            double undouble = double.MaxValue;

            Console.WriteLine(ovint + 1);
            Console.WriteLine(ovfloat + 1);
            Console.WriteLine(ovdouble + 1);
            Console.WriteLine(ovlong + 1);
            Console.WriteLine(unfloat + 0.00000001f);
            Console.WriteLine(undouble * 2000000000);

            
            
         

        }
    }
}
