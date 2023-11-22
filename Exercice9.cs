using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice9
    {
        public void Exercice()
        {
            int number1 = EnterANumber();
            int number2 = EnterANumber();
            int number3 = EnterANumber();
            Random random = new Random();
            int number4 = random.Next(0, 101);
            int number5 = random.Next(0, 101);
            int number6 = random.Next(0, 101);

            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);
            numbers.Add(number5);
            numbers.Add(number6);
            numbers = numbers.OrderByDescending(x => x).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(i);
            }
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
                    Console.WriteLine("Rentrez le premier nombre");
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