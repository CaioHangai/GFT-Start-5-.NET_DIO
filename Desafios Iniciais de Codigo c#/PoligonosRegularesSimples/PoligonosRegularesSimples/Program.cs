using System;

namespace PoligonosRegularesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint N, L;

            string[] v = Console.ReadLine().Split(' ');
            N = uint.Parse(v[0]);
            L = uint.Parse(v[1]);

            uint P = N * L;

            Console.WriteLine(P);
        }
    }
}