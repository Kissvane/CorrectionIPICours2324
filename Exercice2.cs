using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    public class Exercice2
    {
        public void Exercice()
        {
            Console.WriteLine("Quelle est votre date de naissance ?");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            int age = (int)((DateTime.Now - birthDate).TotalDays / 365f);
            
            Console.WriteLine($"Vous avez {age} ans.");
        }
    }
}
