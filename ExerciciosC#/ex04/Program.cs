using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a idade do nadador? ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 5)
            {
                Console.WriteLine("Nadador muito novo, ainda não possui categoria.");
            }
            else if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Nadador pertence a categoria Infantil A.");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Nadador pertence a categoria Infantil B.");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Nadador pertence a categoria Juvenil A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Nadador pertence a categoria Juvenil B.");
            } else {
                Console.WriteLine("Nadador pertence a categoria Senior.");
            }
        }
    }
}
