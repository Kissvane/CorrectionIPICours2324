using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice26
    {
        public void Exercice()
        {
            HashSet<int> hashset = new();
            for (int i = 0; i < 100; i++)
            {
                hashset.Add(i);
            }
            hashset.Add(0);
            for (int i = 41; i < 50; i++)
            {
                hashset.Remove(i);
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach(int i in hashset)
            {
                stringBuilder.Append(i);
                stringBuilder.Append('-');
            }
            stringBuilder.Remove(stringBuilder.Length - 1,1);
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
