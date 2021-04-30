using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos anos você tem? ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int idadeMeses = idade * 12;
            int bissexto = idade / 4;
            int idadeDias = idade * 365 + bissexto;
            int idadeHoras = idadeDias * 24;
            int idadeMinutos = idadeHoras * 60;

            string mensagem = $"Você tem {idadeMeses} meses de idade\n{idadeDias} dias\n{idadeHoras} horas\n{idadeMinutos} minutos";

            Console.Write(mensagem);
        }

    }
}