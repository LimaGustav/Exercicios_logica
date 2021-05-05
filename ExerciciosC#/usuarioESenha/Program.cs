using System;

namespace usuarioESenha
{
    class Program
    {
        static void Main(string[] args)
        {   
            string usuario = "";
            string senha = "";
            do {
                Console.Write("Digita um nome de usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Digite uma senha: ");
                senha = Console.ReadLine();

                if (usuario.ToLower() == senha.ToLower()) {
                    Console.WriteLine("O nome de usuario deve ser diferente da senha!!");
                }
            } while (senha.ToLower() == usuario.ToLower());
            Console.WriteLine("Dados salvos com sucesso.")
;        }
    }
}
