using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    public class Exercice5
    {
        public void Exercice()
        {
            Console.WriteLine("Rentrez le premier nombre");
            int number1 = 0;
            if(!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("il faut taper un nombre !!!");
                Exercice();
                return;
            }

            Console.WriteLine("Rentrez le deuxieme nombre");
            int number2 = 0;
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("il faut taper un nombre !!!");
                Exercice();
                return;
            }
            if(number2 == 0)
            {
                Console.WriteLine("il faut taper un nombre different de 0 !!!");
                Exercice();
                return;
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
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        }
    }
}
