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

            while (sair != 0) // Enquanto sair for diferente de zero o programa continua
            {
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

                bool opcaoInvalida = true;
                while (opcaoInvalida)
                {

                    Console.Write("\nCadastrar pasagem [1]\nListar Passagens [2]\nSair [0]\n-> ");
                    string opcaoMenu = Console.ReadLine();

                    if (c == tamanhoArray) {
                        Console.WriteLine("Limite de passagens já excedeu");
                    }

                    switch (opcaoMenu)
                    {
                        case "1":
                            opcaoInvalida = false; 
                            break;
                        case "2":
                            opcaoInvalida = false;
                            break;
                        case "0":
                            opcaoInvalida = false;
                            sair = 0;
                            break;
                        default:
                            Console.WriteLine("\nOpção invalida. Tente novamente");
                            opcaoInvalida = true;
                            break;
                    }
                    if (opcaoMenu == "1" && c < tamanhoArray) // Se o usuario escolheu cadastrar passagem
                    {
                        string outroPassageiro = "s";
                        while (outroPassageiro == "s")
                        {
                            bool sairMenu = true;
                            Console.Write("Qual o nome do passageiro? ");
                            nomes[c] = Console.ReadLine().ToUpper();

                            Console.Write("Qual o local de origem? ");
                            origens[c] = Console.ReadLine().ToUpper();

                            Console.Write("Qual o local de destino? ");
                            destinos[c] = Console.ReadLine().ToUpper();

                            Console.Write("Qual a data do voo? ");
                            datasVoos[c] = Console.ReadLine();

                            c++;
                            if (c >= 1 && c < tamanhoArray) {
                                Console.WriteLine($"\nVocê pode cadastrar apenas {tamanhoArray} passagens.");
                                Console.WriteLine($"\nJá foram cadastradas {c} passagens\n");
                            }
                            else if (c == tamanhoArray) {
                                Console.WriteLine("Você atingiu o número maximo de passagens cadastradas");
                                outroPassageiro = "n";
                                sairMenu = false;
                            }
                            

                            while (sairMenu)
                            {
                                Console.Write("Deseja cadastrar outro passageiro? (N/S) ");
                                outroPassageiro = Console.ReadLine().ToLower().Substring(0,1);
                                if (outroPassageiro == "n") {
                                    sairMenu = false;
                                }
                                else if (outroPassageiro == "s") {
                                    sairMenu = false;
                                }
                            }
                        }
                        
                    }
                    else if (opcaoMenu == "2") // Se o usuario escolher listar passagens
                    {
                        for (var i = 0; i < c ; i++)
                        {
                            Console.WriteLine($"{i+1}º - {nomes[i]} | {origens[i]} - {destinos[i]} | {datasVoos[i]}");
                        }
                    }
                
                }
                
            }
            
        }
    }
}