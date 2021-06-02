using System;

namespace gerenciamentoProdutos
{
    class Program
    {   
        static int tamanhoArray = 1;
        static int tamanhoCopia = tamanhoArray;
        static string[] nomesProdutos = new string[tamanhoArray];
        static string[] nomesProdutosCopia = new string[tamanhoCopia];
        static float[] valorProdutos = new float[tamanhoArray];
        static float[] valorProdutosCopia = new float[tamanhoCopia];
        static bool[] promocoes = new bool[tamanhoArray];
        static bool[] promocoesCopia = new bool[tamanhoCopia];
        static int c = 0;
        static void Main(string[] args)
        {   
            string opcaoMenu = "";
            while (opcaoMenu != "3")
            {
                opcaoMenu = MostrarMenu(); // Mostra o menu
                if (opcaoMenu == "1")
                {
                    if (c < tamanhoArray) {
                        CadastrarProduto(); // Caso tiver espaços nos arrays para cadastrar produtos ele cadastra
                    } else {
                        AumentarProdutos();
                    }
                    
                }
                else if (opcaoMenu == "2") {
                    ListarProdutos(); // Lista os produtos se a opção escolhida for 2
                }
            }
        }













        static string MostrarMenu() 
        {
            bool opcaoMenuInvalida = true;
            string opcaoMenu;
            do
            {
                // Console.Write(@"                
                //     Gerenciamento de Preço");

                Console.WriteLine("Gerenciamento de Produtos");
                if (c < tamanhoArray)
                {
                    Console.Write("\nCadastrar produtos [1]\nListar produtos cadastrados [2]\nSair do sistema [3]\n-> ");
                } else {
                    Console.Write("\nAumentar a quantidade de produtos [1]\nListar produtos cadastrados [2]\nSair do sistema [3]\n-> ");
                }

                // Console.Write(@"
                // |--------------------------------------|
                // |               MENU                   |
                // |--------------------------------------|
                // |   1 - Cadastrar produtos             |
                // |                                      |
                // |   2 - Listar produtos cadastrados    |
                // |                                      |
                // |   3 - Sair do sistema                |
                // |--------------------------------------|
                // -> ");
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1" || opcaoMenu == "2" || opcaoMenu == "3")
                {
                    opcaoMenuInvalida = false;
                } else {
                    Console.WriteLine("\nOpção invalida. Tente novamente\n");
                }
            } while (opcaoMenuInvalida);
            return opcaoMenu;
        }



        static void CadastrarProduto() 
        {
            bool loop = true;
            while (loop)
            {
                if (c < tamanhoArray) 
                {
                    Console.Write("\nQual o nome do produto? ");
                    nomesProdutos[c] = Console.ReadLine().ToUpper().Trim();

                    bool loopValor = true;
                    do
                    {
                        Console.Write($"Qual o valor de {nomesProdutos[c]} R$");
                        string valorString = Console.ReadLine();
                        bool isFloat = float.TryParse(valorString, out valorProdutos[c]);
                        if (isFloat)
                        {
                            valorProdutos[c] = float.Parse(valorString);
                            loopValor = false;
                        } else {
                            Console.WriteLine("Digite apenas números");
                        }
                    } while (loopValor);
                    

                    bool valorInvlido = true;
                    bool promocao = false;
                    do
                    {
                        Console.Write("Este produto está em promoção? (S/N) ");
                        string promocaoString = Console.ReadLine();

                        if (promocaoString == "s") 
                        {
                            promocao = true;
                            valorInvlido = false;
                            promocoes[c] = promocao;
                        }
                        else if (promocaoString == "n") 
                        {
                            promocao = false;
                            valorInvlido = false;
                            promocoes[c] = promocao;
                        }
                        else {
                            Console.WriteLine("Opção invalida. Tente novamente");
                        }
                    } while (valorInvlido);
                    c++;

                    bool cadastrar = true;
                    do
                    {
                        Console.Write("Deseja cadastrar mais um produto? (S/N) ");
                        string opcaoCadastar = Console.ReadLine();

                        if (opcaoCadastar == "s")
                        {
                            cadastrar = false;
                        }
                        else if (opcaoCadastar == "n") 
                        {
                            cadastrar = false;
                            loop = false;
                        }
                        
                    } while (cadastrar);
                } else
                {
                    Console.WriteLine("\nNúmero máximo de produtos cadastrados excedido\n");
                    loop = false;
                }
                
                
            }

        }



        static void ListarProdutos()
        {
            if (c == 0) {
                Console.WriteLine($@"
                                        Lista de Produtos
                -------------------------------------------------------------------
                                           LISTA VAZIA");
            } else
            {
                string promocoesMensagem;
                Console.WriteLine($@"
                                            Lista de Produtos
                    -------------------------------------------------------------------");
                for (var i = 0; i < c; i++)
                {
                    if (promocoes[i] == true) {
                        promocoesMensagem = "Em promoção";
                    } else {
                        promocoesMensagem = "Preço normal";
                    }
                    Console.WriteLine($@"                       
                                    {i+1}º {nomesProdutos[i]} - R${valorProdutos[i]} - {promocoesMensagem.ToUpper()}");
                }
                // foreach (var item in valorProdutos)
                // {
                //     Console.WriteLine(item);
                // DEBUG }
            }
            
        }


        static void AumentarProdutos() {

            bool isInt = false;
            int produtosAMaisInt = 0;
            while (!isInt)
            {
                Console.Write("Quantos produtos a mais você deseja cadastrar? ");
                string produtosAMaisString = Console.ReadLine();
                isInt = int.TryParse(produtosAMaisString, out produtosAMaisInt);
                if (isInt) {
                    produtosAMaisInt = int.Parse(produtosAMaisString);
                } else {
                    Console.WriteLine("Digite apenas números");
                }

            }
            tamanhoCopia = tamanhoArray + produtosAMaisInt;
            nomesProdutosCopia = new string [tamanhoCopia];
            Array.Copy(nomesProdutos, nomesProdutosCopia, tamanhoArray);
            valorProdutosCopia = new float[tamanhoCopia];
            Array.Copy(valorProdutos, valorProdutosCopia, tamanhoArray);
            promocoesCopia = new bool[tamanhoCopia];
            Array.Copy(promocoes, promocoesCopia, tamanhoArray);
            
            tamanhoArray = tamanhoCopia;
            nomesProdutos = new string[tamanhoArray];
            valorProdutos = new float[tamanhoArray];
            promocoes = new bool[tamanhoArray];

            Array.Copy(nomesProdutosCopia, nomesProdutos, tamanhoArray);
            Array.Copy(valorProdutosCopia, valorProdutos, tamanhoArray);
            Array.Copy(promocoesCopia, promocoes, tamanhoArray);
        }
    }
}
