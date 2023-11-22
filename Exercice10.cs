using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice10
    {
        public void Exercice()
        {
            float number1 = EnterANumber();
            float number2 = EnterANumber();
            float number3 = EnterANumber();

            if (number1 >= number2 && number1 >= number3)
            {
                if(number2 >= number3)
                {
                    Console.WriteLine($"{number1} {number2} {number3}");
                }
                else
                {
                    Console.WriteLine($"{number1} {number3} {number2}");
                }
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                if (number1 >= number3)
                {
                    Console.WriteLine($"{number2} {number1} {number3}");
                }
                else
                {
                    Console.WriteLine($"{number2} {number3} {number1}");
                }
            }
            else if(number3 >= number1 && number3 >= number2)
            {
                if (number1 >= number2)
                {
                    Console.WriteLine($"{number3} {number1} {number2}");
                }
                else
                {
                    Console.WriteLine($"{number3} {number2} {number1}");
                }
            }
        }

        float EnterANumber()
        {
            float number = 0;
            bool numberEntered = false;
            while (!numberEntered)
            {
                try
                {
                    numberEntered = true;
                    Console.WriteLine("Rentrez le premier nombre");
                    number = float.Parse(Console.ReadLine());
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
