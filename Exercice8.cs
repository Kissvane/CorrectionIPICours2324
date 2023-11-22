using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice8
    {
        public void Exercice()
        {
            int number1 = 0;
            bool numberEntered = false;
            while (!numberEntered) 
            {
                try
                {
                    numberEntered = true;
                    Console.WriteLine("Rentrez le premier nombre");
                    number1 = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vous avez tapé autre chose qu'un nombre");
                    numberEntered = false;
                }
            }

            int number2 = 0;
            numberEntered = false;
            while (!numberEntered)
            {
                try
                {
                    numberEntered = true;
                    Console.WriteLine("Rentrez le deuxième nombre");
                    number2 = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vous avez tapé autre chose qu'un nombre");
                    numberEntered = false;
                }
            }

            Add(number1, number2);
            Divide(number1, number2);
        }

        public void Add(int number1, int number2)
        {
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }

        public void Divide(int number1, int number2)
        {
            try
            {
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DIVISION PAR 0 IMPOSSIBLE");
            }
        }
    }
}
