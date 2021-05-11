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
            double litros = Convert.ToDouble(Console.ReadLine());
            
            double valorFinal = 0;
            switch (combustivel) {
                case "g":
                    valorFinal = CalculaGasolina(litros);
                    break;
                
                case "a":
                    valorFinal = CalculaAlcool(litros);
                    break;
            }
            Console.WriteLine($"O valor total a ser pago sera de R${valorFinal}");

        }

        static double CalculaGasolina(double litros) {
            double desconto;
            double precoLitro = 5.30;
            double precoTotal = precoLitro * litros;
            double precoFinal;
            double porcentagemDesconto;
            if (litros > 20) {
                porcentagemDesconto = 0.06;
                desconto = precoTotal * porcentagemDesconto;
            }else {
                porcentagemDesconto = 0.04;
                desconto = precoTotal * porcentagemDesconto;
                precoFinal = precoTotal - desconto;
            }
            precoFinal = precoTotal - desconto;
            return precoFinal;
        }

        static double CalculaAlcool(double litros) {
            double precoLitro = 4.90;
            double precoTotal = precoLitro * litros;
            double precoFinal;
            double porcentagemDesconto;
            double desconto;
            if (litros > 20) {
                porcentagemDesconto = 0.05;
                desconto = precoTotal * porcentagemDesconto;
                Console.WriteLine(desconto);
            }else {
                porcentagemDesconto = 0.03;
                desconto = precoTotal * porcentagemDesconto;
                precoFinal = precoTotal - desconto;
            }
            precoFinal = precoTotal - desconto;
            return precoFinal;
        }
    }
}
