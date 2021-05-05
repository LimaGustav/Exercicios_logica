using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {   
            string separador = new String('-', 20); //Monta uma sequencia de 20 "-"

            Console.WriteLine(separador);
            Console.WriteLine("Fibonacci");

            Console.WriteLine(separador); // Separa com uma linha

            double nTermo; // N ésimo termo 
            double termoAtual = 0; // 
            double termoSeguinte = 1;

            Console.Write("Quanto termos da sequencia devo mostrar? ");
            int termos = int.Parse(Console.ReadLine());
            // Pergunta a quantidade de termos que vai mostrar e armazena em "termos"

            Console.WriteLine(separador); // Separa com uma linha

            for (int i = 0; i < termos; i++)
            {
                Console.Write(termoAtual + "-> "); 
                nTermo = termoAtual + termoSeguinte;
                termoAtual = termoSeguinte;
                termoSeguinte = nTermo;
            }
            Console.WriteLine("Fim");

            Console.WriteLine(separador);
        }
    }
}
