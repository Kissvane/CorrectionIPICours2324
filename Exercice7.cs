using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice7
    {

        public void Exercice(int temperature)
        {
            if(temperature < 0)
            {
                Console.WriteLine("SOLIDE");
            }
            else if (temperature < 100)
            {
                Console.WriteLine("LIQUIDE");
            }
            else
            {
                Console.WriteLine("GAZEUX");
            }

            switch (temperature)
            {
                case < 0:
                    Console.WriteLine("SOLIDE");
                    break;
                case < 100:
                    Console.WriteLine("LIQUIDE");
                    break;
                default:
                    Console.WriteLine("GAZEUX");
                    break;
            } 
        }
    }
}
