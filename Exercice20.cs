using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice20
    {
        public void Exercice(int[] array, int[] array2, int index)
        {
            int[] result = new int[array.Length+array2.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if(i < index)
                {
                    result[i] = array[i];
                }
                else if (i < index + array2.Length)
                {
                    result[i] = array2[i-index];
                }
                else
                {
                    result[i] = array[i - array2.Length];
                }
                Console.WriteLine(result[i]);
            }
        }
    }
}
