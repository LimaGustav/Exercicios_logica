using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoInvalida = true;
            string resposta = "";
            string operacao = "";
            double[] numeros;
            numeros = new double[2];
            bool confirmacao = true;
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("Qual operação você deseja fazer?");
                while (opcaoInvalida)
            {
                Console.Write("Adição[1] Subtração[2] Multiplicação[3] Divisão[4] ");
                resposta = Console.ReadLine();
                
                switch (resposta)
                {
                    case "1":
                        opcaoInvalida = false;
                        operacao = "Somar";
                        break;
                    case "2":
                        opcaoInvalida = false;
                        operacao = "Subtrair";
                        break;
                    case "3":
                        opcaoInvalida = false;
                        operacao = "Multiplicar";
                        break;
                    case "4":
                        opcaoInvalida = false;
                        operacao = "Dividir";
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Tente novamente");
                        opcaoInvalida = true;
                        break;
                }
                   
            }
            
            
            for (var i = 0; i < 2; i++)
            {
                Console.Write($"Qual o {i+1}º número que você quer {operacao}? ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            if (resposta == "1")
            {
                double resultado = Somar(numeros[0], numeros[1]);
                Console.WriteLine($"O resultado dessa operação é igual {resultado}");
            }
            else if (resposta == "2") {
                double resultado = Subrair(numeros[0], numeros[1]);
                Console.WriteLine($"O resultado dessa operação é igual {resultado}");
            }
            else if (resposta == "3") {
                double resultado = Multiplicar(numeros[0], numeros[1]);
                Console.WriteLine($"O resultado dessa operação é igual {resultado}");
            }
            else if (resposta == "4") {
                double resultado = Dividir(numeros[0], numeros[1]);
                Console.WriteLine($"O resultado dessa operação é igual {resultado}");
            }

            while (confirmacao) {
                Console.Write("Deseja fazer outra operação? Sim(s)/Não(n) ");
                continuar = Console.ReadLine();
                continuar = continuar.ToLower().Substring(0,1);
                if (continuar == "s") {
                    opcaoInvalida = true;
                    confirmacao = false;
                }
                else if (continuar == "n") {
                    confirmacao = false;
                } else {
                    Console.WriteLine("Opção invalida. Tente novamente. ");
                    confirmacao = true;
                }

        }
            }

        static double Somar(double n1, double n2) 
        {
            return n1 + n2;
        }

        static double Subrair(double n1, double n2)
        {
            return n1 - n2;
        }

        static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
}
