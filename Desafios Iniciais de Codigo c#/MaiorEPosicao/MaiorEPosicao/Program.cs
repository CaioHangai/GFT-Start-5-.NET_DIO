/* Você recebeu o desafio de ler 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

|Exemplos de Entrada | Exemplos de Saída          |
|--------------------|----------------------------|
|  2                 | 34565                      |
|  113            	 | 4                          |
|  45                |                            | 
|  34565           	 |                            |
|  6                 |                            |
|  ....              |                            |
|  8                 |                            | 
|____________________|____________________________|*/

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