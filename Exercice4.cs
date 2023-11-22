using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    public class Exercice4
    {
        public void Exercice()
        {
            Console.WriteLine("Rentrez le premier nombre");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Rentrez le deuxieme nombre");
            int number2 = int.Parse(Console.ReadLine());

            Add(number1, number2);
            Divide(number1, number2);
        }

        public void Add(int number1, int number2)
        {
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }

        public void Divide(int number1, int number2)
        {
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        }
    }
}
