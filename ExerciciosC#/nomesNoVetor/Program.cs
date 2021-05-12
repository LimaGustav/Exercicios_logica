using System;

namespace nomesNoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            Console.WriteLine($"Digite o nome de {nomes.Length} pessoas");
            for (int i = 0; i < nomes.Length; i++) {
                Console.Write($"Digite o {i+1}º nome: ");
                nomes[i] = Console.ReadLine().ToUpper().Trim();
            }

            Console.Write("Digite o nome que deseja buscar: ");
            string busca = Console.ReadLine().ToUpper().Trim();
            bool achei = false;

            foreach (var item in nomes)
            {
                if (item == busca) {
                    achei = true;
                }
            }
            if (achei) {
                Console.WriteLine($"Achei o nome {busca}");
            }else {
                Console.WriteLine($"Não achei o nome {busca}");
            }
        }
    }
}
