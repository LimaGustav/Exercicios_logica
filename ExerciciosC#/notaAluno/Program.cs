using System;

namespace notaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            do
            {
                Console.Write("Digita uma note entre 0 e 10: ");
                nota = int.Parse(Console.ReadLine());
                if (nota > 10) {
                    Console.WriteLine("Nota invalida");
                }
            } while (nota > 10);
        }
    }
}
