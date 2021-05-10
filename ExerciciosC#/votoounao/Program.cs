using System;

namespace votoounao
{
    class Program
    {   
        static void Main(string[] args)
        {
            int anoAtual = System.DateTime.Now.Year;  // Pega o ano atual e armazena em anoAtual

            Console.Write("Digite seu ano de nascimento: "); 
            int anoNascimento = int.Parse(Console.ReadLine()); // Salva o valor digitado em ano Nascimento

            int idade = anoAtual - anoNascimento; // Define a idade

            bool podeVotar = idade >= 16; /* Se a idade for maior ou igual a 16 podeVotar recebe true
                                            Caso contrario recebe false */

            if (podeVotar) {
                Console.WriteLine($"Você tem {idade} anos, já pode votar.");
            }else {
                Console.WriteLine($"Você tem {idade} anos, ainda não pode votar.");
            }
        }
    }
}
