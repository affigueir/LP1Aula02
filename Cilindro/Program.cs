using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do cilindro:");
            string h = Console.ReadLine();

            Console.WriteLine("Insira o raio do cilindro:");
            string r = Console.ReadLine();

            float h1 = float.Parse(h);
            float r1 = float.Parse(r);

            float pi = 3.1415926f;

            float V = pi * (r1 * r1) * h1;

            float S = 2 * pi * r1 * ( r1 + h1);

            Console.WriteLine($"Volume do Cilindro: {V} Area Superficie : {S}");



        }
    }
}
