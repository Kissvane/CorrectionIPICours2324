using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice23
    {
        public void Exercice()
        {
            Console.WriteLine("Entrez une string");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    Console.WriteLine($"{input} n'est pas un palindrome");
                    return;
                }
            }

            Console.WriteLine($"{input} est un palindrome");
        }
    }
}
