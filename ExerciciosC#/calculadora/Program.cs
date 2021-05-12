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
            while (continuar == "s") // Enquanto o a variavel continuar for igual a "s" (SIM), o codigo abaixo serpá efetuado
            {
                Console.WriteLine("Qual operação você deseja fazer?");
                while (opcaoInvalida) // Enquanto operação invalida for True ele vai continuar perguntando qual operação o usuário quer fazer
            {
                Console.Write("Adição[1] Subtração[2] Multiplicação[3] Divisão[4] ");
                resposta = Console.ReadLine(); // Guarda a operação que o usuário escolheu na varíavel resposta
                
                /* Switch feito para dar nome as operações escolhidas
                operação 1 recebe o nome Somar por exemplo*/
                switch (resposta) 
                {
                    // Atribiu o nome para a operação e muda o valor de opçaoInvalida para false
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
            
            
            for (var i = 0; i < 2; i++) // Ele pede 2 vezes um número para executar a operação. 
            {
                Console.Write($"Qual o {i+1}º número que você quer {operacao}? ");
                numeros[i] = double.Parse(Console.ReadLine()); /* Armazena o primeiro e o segundo número escolhido no array numeros*/
            }

            if (resposta == "1") // Caso a respota da pergunta da operação foi 1 ele vai somar
            {
                double resultado = Somar(numeros[0], numeros[1]); // efetua a soma usando a função declarada
                Console.WriteLine($"O resultado dessa operação é igual {resultado}"); // Exibe o resultado da soma
            }
            else if (resposta == "2") /* Caso a resposta da pergunta da operação foi 2 ele vai subtrair */ {
                double resultado = Subrair(numeros[0], numeros[1]); // efetua a subtração usando a função declarada
                Console.WriteLine($"O resultado dessa operação é igual {resultado}"); // Exibe o resultado da subtração
            }
            else if (resposta == "3") /* Caso a resposta da pergunta da operação foi 3 ele vai multiplicar */ {
                double resultado = Multiplicar(numeros[0], numeros[1]); // Efetua a multiplicação usando a função declarada.  
                Console.WriteLine($"O resultado dessa operação é igual {resultado}"); // Exibe o resultado da multiplicação
            }
            else if (resposta == "4") /* Caso a resposta da pergunta da operação foi 4 ele vai dividir */ {
                double resultado = Dividir(numeros[0], numeros[1]); // Efetua a divisão usando a função declarada 
                Console.WriteLine($"O resultado dessa operação é igual {resultado}"); // Exibe o resultado
            }

            while (confirmacao) /* Vai continuar efetuando o código enquanto confirmação for true */ {
                Console.Write("Deseja fazer outra operação? Sim(s)/Não(n) ");
                continuar = Console.ReadLine();
                continuar = continuar.ToLower().Substring(0,1); // Pega a primeira letra da palavra respondida e passa para o minusculo
                if (continuar == "s") {
                    opcaoInvalida = true; // Caso a respota for sim, ele poem opçãoInvalida = true para rodar denovo toda cadeia de codigo
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
