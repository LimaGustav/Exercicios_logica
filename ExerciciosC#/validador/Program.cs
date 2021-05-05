using System;

namespace validador
{
    class Program
    {
        static void Main(string[] args)
        {   

            string separador = new String('=', 20);

            string nome = "";
            do
            {
                Console.WriteLine(separador);

                Console.Write("Digite um nome: ");
                nome = Console.ReadLine().Trim().ToUpper();
                if (nome == "") {
                    Console.WriteLine(separador);
                    Console.WriteLine("Idade invalida\nTente novamente");
    
                }

            } while (nome == "");

            int idade;
            do
            {
                Console.WriteLine(separador);

                Console.Write("Digite uma idade: ");
                string idadeString = (Console.ReadLine());
                if (idadeString == "") {
                    idadeString = "-1";
                }
                idade = int.Parse(idadeString);
                if (idade > 150 || idade < 0) {
                    Console.WriteLine(separador);
                    Console.WriteLine("Idade invalida\nTente novamente");
                }

            } while (idade > 150 || idade < 0);

            double salario;
            do
            {
                Console.WriteLine(separador);

                Console.Write("Digite uma salario: R$");
                salario = Convert.ToInt32(Console.ReadLine());

            } while (salario < 0);

            string estadoCivilValido = "";
            string estadoCivil;
            do
            {
                Console.WriteLine(separador);
                Console.Write("Digite um estado civil ('s'Solteiro(a)) ('c'Casado(a)) ('v'Viuvo(a)) ('d'Divorciado(a)) ");
                estadoCivilValido = Console.ReadLine().Trim().ToLower();

                switch (estadoCivilValido) {
                    case "s":
                        estadoCivil = "Solteiro";
                        break;
                    case "c":
                        estadoCivil = "Casado";
                        break;
                    case "v":
                        estadoCivil = "Viuvo";
                        break;
                    case "d":
                        estadoCivil = "Divorciado";
                        break;
                    default: 
                        estadoCivil = "";
                        break;
                }

                if (estadoCivilValido == "s" || estadoCivilValido == "c" || estadoCivilValido == "v" || estadoCivilValido == "d") {
                    estadoCivilValido = "s";
                } else {
                    estadoCivilValido = "amendoim";
                }
            } while (estadoCivilValido != "s");
            Console.WriteLine("Dados validados");
            Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nSalario: R${salario}\nEstado Civil: {estadoCivil}");
        }
    }
}
