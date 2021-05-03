using System;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine();
            nome = nome.ToLower();

            string letra = nome.Substring(0, 1);

            switch (letra) {

                case "a":
                    Console.WriteLine("Seu nome começa com A");
                    break;
                case "e":
                    Console.WriteLine("Seu nome começa com E");
                    break;
                case "i":
                    Console.WriteLine("Seu nome começa com I");
                    break;
                case "o":
                    Console.WriteLine("Seu nome começa com O");
                    break;
                case "u":
                    Console.WriteLine("Seu nome começa com U");
                    break;

                default:
                    Console.WriteLine("Seu nome não começa com vogal");
                    break;
            }
            
        }
    }
}
