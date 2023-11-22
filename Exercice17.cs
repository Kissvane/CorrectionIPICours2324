using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice17
    {
        public void Exercice()
        {
            int[] array = new int[9];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5+i;
                if (i == 2)
                {
                    array[2] = 111;
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
