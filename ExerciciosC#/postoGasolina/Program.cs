using System;

namespace postoGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustível você vai abastecer? ");
            Console.Write("Gasolina (G) Álcool (A) ");

            string combustivel = Console.ReadLine().ToLower(); // Salva o combustivel escolhido em combustivel, ja em minusculo

            combustivel = combustivel.Substring(0,1); // Pega apenas a primeira letra.

            Console.Write("Quantos litros? ");
            double litros = Convert.ToDouble(Console.ReadLine()); // Armazena quantos litros o usuario quer
            
            double valorFinal = 0;
            switch (combustivel) 
            {
                case "g":
                    valorFinal = CalculaGasolina(litros);
                    break; // Caso o usuario escolher gasolina a função CalculaGasolina vai fazer o calculo do valor
                
                case "a":
                    valorFinal = CalculaAlcool(litros);
                    break; // Caso o usuario escolher alcool a função CalculaAlcool vai fazer o calculo do valor
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            Console.WriteLine($"O valor total a ser pago com desconto sera de R${valorFinal.ToString("N2")}");

        }

        static double CalculaGasolina(double litros) {
            double desconto;
            double precoLitro = 5.30;
            double precoTotal = precoLitro * litros;
            double precoFinal;
            double porcentagemDesconto;
            // Declaração de todas as variaveis usadas
            if (litros > 20) {
                porcentagemDesconto = 0.06; // Se for mais de 20 litros o desconto é de 6%
                desconto = precoTotal * porcentagemDesconto; // Calcula o desconto baseado no preço total
            }else {
                porcentagemDesconto = 0.04; // Se for mais de 20 litros o desconto é de 4%
                desconto = precoTotal * porcentagemDesconto; // Calcula o desconto baseado no preço total
            }
            precoFinal = precoTotal - desconto; // Aplica o desconto no preço total e salva no preço final

            return precoFinal;
        }

        static double CalculaAlcool(double litros) {
            double precoLitro = 4.90;
            double precoTotal = precoLitro * litros;
            double precoFinal;
            double porcentagemDesconto;
            double desconto;
            // Declaração de todas as variaveis usadas
            if (litros > 20) {
                porcentagemDesconto = 0.05; // Se for mais de 20 litros o desconto é de 5%
                desconto = precoTotal * porcentagemDesconto; // Calcula o desconto baseado no preço total
            }else {
                porcentagemDesconto = 0.03;
                desconto = precoTotal * porcentagemDesconto; // Se for mais de 20 litros o desconto é de 3%
                precoFinal = precoTotal - desconto; // Calcula o desconto baseado no preço total
            }
            precoFinal = precoTotal - desconto; // Aplica o desconto no preço total e salva no preço final
            return precoFinal;
        }
    }
}
