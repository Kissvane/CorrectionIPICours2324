using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    public class Exercice1
    {
        public static void Exercice()
        {
            Console.WriteLine("Quel est votre nom ?");
            string name = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Bonjour {firstName} {name} !");
        }
    }
}
