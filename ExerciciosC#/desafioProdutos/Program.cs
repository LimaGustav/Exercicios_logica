using System;

namespace desafioProdutos
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] produtos;
            int[] quantidadeProduto;
            double[] preco;
            Console.Write("Quantos produtos você deseja cadastrar? ");
            int quantidadeProdutosCadastrados = int.Parse(Console.ReadLine());

            produtos = new string[quantidadeProdutosCadastrados];
            quantidadeProduto = new int[quantidadeProdutosCadastrados];
            preco = new double[quantidadeProdutosCadastrados];

            for (int i = 0; i < quantidadeProdutosCadastrados; i++)
            {
                Console.Write($"Qual é o {i+1}º produto? ");
                produtos[i] = Console.ReadLine();

                Console.Write($"Qual é a quantidade de {produtos[i]}? ");
                quantidadeProduto[i] = int.Parse(Console.ReadLine());

                Console.Write($"Qual o preço de {produtos[i]} R$");
                preco[i] = double.Parse(Console.ReadLine());
            
            }

            Console.WriteLine(
                
                $@"
                ----------------------------------------------------
                |Produto              Quantidade              Preço|"
                
                );

            for (int i = 0; i < quantidadeProdutosCadastrados; i++)
            {
                Console.WriteLine($@"                |{produtos[i]}                {quantidadeProduto[i]}                {preco[i]}|
                ");
            }
            
        }
    }
}
