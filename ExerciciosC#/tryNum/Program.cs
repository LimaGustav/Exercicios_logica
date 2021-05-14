using System;

namespace tryNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número ");
            string numeroString = Console.ReadLine();
            float numeroFloat;
            bool isFloat = float.TryParse(numeroString, out numeroFloat);
            if (isFloat) {
                numeroFloat = float.Parse(numeroString);
                Console.WriteLine($"O numero {numeroFloat} foi convertido para float");
            } else {
                Console.WriteLine("Digite apenas números");
            }
        }
    }
}
