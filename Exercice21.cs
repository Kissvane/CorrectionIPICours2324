using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice21
    {
        public void Exercice()
        {
            Console.WriteLine("Entrez un mot");
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            for(int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append(array[i]);
                stringBuilder.Append('.');
                stringBuilder2.Append(array[array.Length-i-1]);
            }
            stringBuilder.Remove(stringBuilder.Length - 1,1);
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine(stringBuilder2.ToString());
        }
    }
}
