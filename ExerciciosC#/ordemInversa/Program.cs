using System;

namespace ordemInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[15];
            
            Console.WriteLine(numeros.Length);
            for (int i = 0; i < 15; i++) {
                Console.Write($"Digite o {i+1}º número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            double[] numerosInverso = new double [numeros.Length];
            int c = 0;
            for (int i = numeros.Length; i > 0; i--) {
                numerosInverso[c] = numeros[i-1];
                c++;
            } 

            foreach (var item in numerosInverso)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
