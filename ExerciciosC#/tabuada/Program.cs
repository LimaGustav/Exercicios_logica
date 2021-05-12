using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Tabuada do {i}");
                Console.WriteLine($"");
                for (int c = 1; c <= 10; c++)
                {
                    Console.WriteLine($"{i}x{c} = {i*c}");
                }
            } 
        }
    }
}
