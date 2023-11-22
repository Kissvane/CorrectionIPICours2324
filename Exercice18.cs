using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice18
    {
        public void Exercice(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("------------------------");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0)
                {
                    array[i] = i;
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
