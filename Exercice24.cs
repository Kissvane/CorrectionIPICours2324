using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice24
    {
        public void Exercice()
        {
            string input = "";
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Tapez un nom");
                input = Console.ReadLine();
                if (ContainNumber(input) && names.Count >= 6) break;
                else if (ContainNumber(input)) Console.WriteLine("Vous devez au moins rentrer 6 noms");
                else if (!ContainNumber(input)) names.Add(input);
            }
            names.RemoveAt(1);
            names.RemoveAt(3);
            names.Insert(2,"Toto");
            names.Reverse();

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
        }

        bool ContainNumber(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }
    }
}
