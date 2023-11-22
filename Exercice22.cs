using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice22
    {
        public void Exercice(string input, char replacement)
        {
            /*StringBuilder builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '#')
                    builder.Append(input[i]);
                else
                    builder.Append(replacement);
            }
            Console.WriteLine(builder.ToString());*/

            Console.WriteLine(input.Replace('#', replacement));
        }
    }
}
