using System;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {   
            string romano = "";
            Console.Write("Escreva um algarismo romano de 1 a 10: ");
            romano = Console.ReadLine().ToUpper();
            switch (romano) {

                case "I":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 1");
                    break;

                case "II":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 2");
                    break;

                case "III":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 3");
                    break;

                case "IV":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 4");
                    break;

                case "V":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 5");
                    break;

                case "VI":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 6");
                    break;

                case "VII":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 7");
                    break;

                case "VIII":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 8");
                    break;

                case "IX":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 9");
                    break;

                case "X":
                    Console.WriteLine ($"{romano} em Algarismos Indo-Arábicos é 10");
                    break;

                default:
                    Console.WriteLine($"{romano} não é um numero romano entre 1 e 10");
                    break;
            }


        }
    }
}
