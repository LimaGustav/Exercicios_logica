using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o salario? R$");
            float salario = Convert.ToUInt32(Console.ReadLine());

            if (salario < 500)
            {
                salario = salario * 1.3f;
                Console.WriteLine($"O salario foi reajustado, passou a ser R${salario}.");
            }else {
                Console.WriteLine($"O salario não sofreu reajuste, continuara sendo R${salario}.");
            }
        }
    }
}
