using System;

namespace exemploRepetição
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "s";
            while (resposta == "s")
            {
                Console.Write("Escolha a idade do jogador: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade > 18) {
                    Console.WriteLine("A categoria Senior foi retira por motivos da pandemia");
                }
                else if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Nadador pertence a categoria Infantil A.");
                }
                else if (idade >= 8 && idade <= 10)
                {
                    Console.WriteLine("Nadador pertence a categoria Infantil B.");
                }
                else if (idade >= 11 && idade <= 13)
                {
                    Console.WriteLine("Nadador pertence a categoria Juvenil A.");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Nadador pertence a categoria Juvenil B.");
                }
                else {
                    Console.WriteLine("Categoria inexistente");
                }
                Console.Write("Deseja digitar outra idade? (S/N) ");
                resposta = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Programa Finalizado");

        }
    }
}
