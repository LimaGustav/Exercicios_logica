using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");

            double nTermo;
            double termoAnterior = 0;
            double termoAtual = 1;
            for (int i = 0; i < 50; i++)
            {
                nTermo = termoAnterior + termoAtual;
                termoAnterior = termoAtual;
                termoAtual = nTermo;

                Console.WriteLine(termoAnterior);
            }
        }
    }
}
