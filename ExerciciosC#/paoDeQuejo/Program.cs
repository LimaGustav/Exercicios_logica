using System;

namespace paoDeQuejo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] embalagensPaoDeQueijo = null;
            Console.Write("Quantas embalagens de pão de queijo na prateleira: ");
            int quantidadePaoDeQueijo = int.Parse(Console.ReadLine());

            embalagensPaoDeQueijo = new int[quantidadePaoDeQueijo];

            for (int i = 0; i < quantidadePaoDeQueijo; i++)
            {
                Console.Write($"Quantos pães de queijo tem na {i+1}º embalagem: ");
                embalagensPaoDeQueijo[i] = int.Parse(Console.ReadLine());
            }

            int c = 1;
            foreach (var item in embalagensPaoDeQueijo)
            {
                Console.WriteLine($"A {c}º Embalagem tem {item} pães de queijo");
                c++;
            }
        }
    }
}
