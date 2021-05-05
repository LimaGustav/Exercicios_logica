using System;

namespace validador
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nome = "";
            do
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine().Trim();

            } while (nome == "");

            int idade;
            do
            {
                Console.Write("Digite uma idade: ");
                idade = int.Parse(Console.ReadLine());

            } while (idade > 150 || idade < 0);

            double salario;
            do
            {
                Console.Write("Digite uma salario: R$");
                salario = Convert.ToInt32(Console.ReadLine());

            } while (salario < 0);

            string estadoCivil = "";
            do
            {
                Console.Write("Digite um estado civil ('s'Solteiro(a)) ('c'Casado(a)) ('v'Viuvo(a)) ('d'Divorciado(a)) ");
                estadoCivil = Console.ReadLine();

                if (estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil == "d") {
                    estadoCivil = "s";
                } else {
                    estadoCivil = "amendoim";
                }
            } while (estadoCivil != "s");
            Console.Write("Dados validados\nArmazenados com sucesso");
        }
    }
}
