using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice13
    {
        public void Exercice()
        {
            bool isNumber = true;
            int result = 0;
            int number = 0;
            while (isNumber)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                if(int.TryParse(input, out number))
                {
                    result += number;
                }
                else
                {
                    Console.WriteLine(result);
                    return;
                }
            }
        }
    }
}
