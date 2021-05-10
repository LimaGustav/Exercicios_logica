using System;

namespace produtoDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o produto? ");
            string produto = Console.ReadLine();

            Console.Write($"Qual o preço de {produto} R$");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Qual a quantidade de {produto} R$");
            int quantidade = int.Parse(Console.ReadLine());

            double total = quantidade * preco;
            double desconto;
            if (quantidade <= 5) {
                desconto = total * 0.02;
            }
            else if (quantidade > 5 && quantidade <= 10) {
                desconto = total * 0.03;
            } else {
                desconto = total * 0.05;
            }
            double totalAPagar = total - desconto;

            Console.WriteLine($"O total é de R${total}, com desconto de R${desconto}.");
            Console.WriteLine($"Total a pagar R${totalAPagar}");
        }
    }
}
