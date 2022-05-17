/*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
 * A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, 
 * a nota B tem peso 3 e a nota C tem peso 5. 
 * Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

Saída
Imprima a variável MEDIA conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

Exemplos de Entrada	
5.0 | 6.0 | 7.0|

Exemplos de Saída
MEDIA = 6.3 */

using System;
using System.Globalization;

namespace Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesoA = 2, pesoB = 3, pesoC = 5, notaA, notaB, notaC, media;

            notaA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (notaA * pesoA + notaB * pesoB + notaC * pesoC) / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = " + media.ToString("f1", CultureInfo.InvariantCulture));
        }
    }
}