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

            float V = Convert.ToSingle(Math.PI * (r1 * r1) * h1);

            float S = Convert.ToSingle(2 * Math.PI * r1 * ( r1 + h1));

            Console.WriteLine($"Volume do Cilindro: {V} Area Superficie : {S}");



        }
    }
}
