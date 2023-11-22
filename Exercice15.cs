using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice15
    {
        public void Exercice()
        {
            int result = 0;
            string input = Console.ReadLine();
            while (IsNumber(input))
            {
                result += int.Parse(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(result);
        }

        bool IsNumber(string input)
        {
            foreach (char c in input)
            {
                if(!char.IsDigit(c)) return false;
            }
            return true;
        }
    }
}
