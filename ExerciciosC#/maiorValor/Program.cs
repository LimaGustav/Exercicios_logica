using System;

namespace maiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double [10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            double maiorValor = numeros[0];
            double menorValor = numeros[0];
            foreach (var item in numeros)
            {
                if (maiorValor < item) {
                    maiorValor = item;
                }
                if (menorValor > item) {
                    menorValor = item;
                }
            }

            Console.WriteLine($"O maior valor digitado é {maiorValor}");
            Console.WriteLine($"O menor valor digitado é {menorValor}");
        }
    }
}
