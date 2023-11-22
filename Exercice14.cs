using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice14
    {
        public void Exercice()
        {
            int result = EnterANumber();
            int divisionNumber = 0;
            while(result > 1)
            {
                result = result / 2;
                divisionNumber++;
            }
            Console.WriteLine($"Division number is {divisionNumber}");
        }

        int EnterANumber()
        {
            int number = 0;
            bool numberEntered = false;
            while (!numberEntered)
            {
                try
                {
                    numberEntered = true;
                    Console.WriteLine("Rentrez un nombre");
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vous avez tapé autre chose qu'un nombre");
                    numberEntered = false;
                }
            }
            return number;
        }
    }
}
