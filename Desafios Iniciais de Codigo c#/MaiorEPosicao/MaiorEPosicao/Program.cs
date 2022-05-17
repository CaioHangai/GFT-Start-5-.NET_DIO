using System;

namespace MaiorEPosicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorEntrada;
            int maiorNumero = 0;
            int posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                valorEntrada = int.Parse(Console.ReadLine());

                if (valorEntrada > maiorNumero)
                {
                    maiorNumero = valorEntrada;
                    posicao = i;
                }
            }
            Console.WriteLine(maiorNumero);
            Console.WriteLine(posicao);
        }
    }
}