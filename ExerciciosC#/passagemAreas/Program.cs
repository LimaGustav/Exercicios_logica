using System;

namespace passagemAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Âgencia Turismo");
            int sair = 1;
            bool senhaIncorreta = true;
            int tamanhoArray = 2;
            string[] nomes = new string[tamanhoArray];
            string[] origens = new string[tamanhoArray];
            string[] destinos = new string[tamanhoArray];
            string[] datasVoos = new string[tamanhoArray];
            int c = 0;

            string senhaMenu;
                    
            while (senhaIncorreta)
            {
                Console.Write("Insira a senha de acesso: ");
                senhaMenu = Console.ReadLine().Trim(); // Salva a senha digita na variavel senhaMenu

                if (senhaMenu == "123456") // Se a senha armazenada em senhaMenu for igual "123456"
                {
                    senhaIncorreta = false; // Senha Incorreta recebe false para sair do loop
                } else {
                    Console.WriteLine("Senha incorreta. Tente novamente"); // Aparece a mensagem e continua no loop
                }
            }

            while (sair != 0) // Enquanto sair for diferente de zero o programa continua
            {

                bool opcaoInvalida = true;
                while (opcaoInvalida) // Equando a opção invalida for true o while vai rodar
                {

                    Console.Write("\nCadastrar passagem [1]\nListar passagens [2]\nSair [0]\n-> "); // Opções do menu
                    string opcaoMenu = Console.ReadLine(); // Armezana as opções do menu na variavel opcaoMenu

                    if (c == tamanhoArray && opcaoMenu == "1") // Se o contador de passageiros for igual o tamanho do array e o usuriao escolher cadastrar uma nova passagem ele exibe a mensagem
                    {
                        Console.WriteLine("Limite de passagens já excedeu"); // mensagem a ser exibida.
                    }

                    switch (opcaoMenu) 
                    {
                        // Casos que podem ser escolhidos na opcaoMenu
                        case "1":
                            opcaoInvalida = false; // Sai do while que pergunta a opçao do menu
                            break;
                        case "2":
                            opcaoInvalida = false; // Sai do while que pergunta a opçao do menu
                            break;
                        case "0":
                            opcaoInvalida = false; // Sai do while que pergunta a opçao do menu
                            sair = 0; // Sai do programa
                            Console.WriteLine("Obrigado por utilizar nosso sistema."); // Mensagem de quando o usuario sair
                            break;
                        default:
                            Console.WriteLine("\nOpção invalida. Tente novamente"); // Caso não for escolhida nenhuma das opções acima
                            opcaoInvalida = true; // Continua no loop de escolher a opção
                            break;
                    }
                    if (opcaoMenu == "1" && c < tamanhoArray) // Se o usuario escolheu cadastrar passagem
                    {
                        string outroPassageiro = "s";
                        while (outroPassageiro == "s") // Enquanto ele quiser cadastrar o outro passageiro ele vai ficar no loop
                        {
                            bool sairMenu = true;
                            Console.Write("Qual o nome do passageiro? ");
                            nomes[c] = Console.ReadLine().ToUpper(); // Armazena o nome do passageiro dentro do array nomes na posição [c] 

                            Console.Write("Qual o local de origem? "); 
                            origens[c] = Console.ReadLine().ToUpper(); // Armazena o local de origem dentro do array origens na posição [c]

                            Console.Write("Qual o local de destino? ");
                            destinos[c] = Console.ReadLine().ToUpper(); // Armazena o local de destino dentro do array destinos na posição [c]

                            Console.Write("Qual a data do voo? "); 
                            datasVoos[c] = Console.ReadLine(); // Armazena a data do voo dentro do array datasVoos na posição [c]

                            c++; // Contador que começa no 0 e vai somando 1 a cada vez q o loop rodar.

                            if (c >= 1 && c < tamanhoArray) { // c é o contador declarado acima
                                Console.WriteLine($"\nVocê pode cadastrar apenas {tamanhoArray} passagens."); // Você só pode cadastrar passagens até lotar os espaços do array
                                Console.WriteLine($"\nJá foram cadastradas {c} passagens\n"); // Exibe quantos passageiros foram cadastrados baseado no contador c
                            }
                            else if (c == tamanhoArray) {
                                Console.WriteLine("Você atingiu o número maximo de passagens cadastradas"); // Se o contador atingir o numero de espaços no array
                                outroPassageiro = "n"; // Sai no loop de cadastrar passageiro
                                sairMenu = false; // Poem o sair menu para false para não aparecer a opção de cadastrar um outro passageiro
                            }
                            

                            while (sairMenu) // Equanto sairMenu for true o loop continua rodando
                            {
                                Console.Write("Deseja cadastrar outro passageiro? (N/S) ");
                                outroPassageiro = Console.ReadLine().ToLower().Substring(0,1);
                                if (outroPassageiro == "n") {
                                    sairMenu = false;
                                }
                                else if (outroPassageiro == "s") {
                                    sairMenu = false;
                                }
                                // Se o usuario digitar qualquer outra coisa alem de s ou n o programa continua no loop
                            }
                        }
                        
                    }
                    else if (opcaoMenu == "2") // Se o usuario escolher listar passagens
                    {
                        Console.WriteLine("\nLista de passagens\n");
                        for (var i = 0; i < c ; i++) // Lista as passagens com seus atributos
                        {
                            Console.WriteLine($"{i+1}º - {nomes[i]} | {origens[i]} - {destinos[i]} | {datasVoos[i]}");
                        }
                    }
                
                }
                
            }
            
        }
    }
}