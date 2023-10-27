using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    public class Exercice3
    {
        public void Exercice()
        {
            Console.WriteLine("Quel est le prix HT du produit ?");
            int basePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Quel est le taux de tva (entre 0 et 100)?");
            float tva = float.Parse(Console.ReadLine());

            Console.WriteLine($"Le prix TTC est de {basePrice+ (int)(basePrice *tva/100f)}");
        }
    }
}
