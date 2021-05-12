using System;

namespace maiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double [10]; // Cria um array de tipo double com 10 espaços
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine()); // Armazena os números escolhidos no array numeros com o index i (i vai do 0 ao 10)
            }

            double maiorValor = numeros[0];
            double menorValor = numeros[0];
            foreach (var item in numeros)
            {
                if (maiorValor < item) /* Se o Maiorvalor for menor que um número dentro de numeros, o  Maiorvalor recebe o número*/
                {
                    maiorValor = item;
                }
                if (menorValor > item)  /* Se o Menorvalor for maior que um número dentro de numeros, o Menorvalor recebe o número */
                {
                    menorValor = item;
                }
            }

            Console.WriteLine($"O maior valor digitado é {maiorValor}");
            Console.WriteLine($"O menor valor digitado é {menorValor}");
        }
    }
}
