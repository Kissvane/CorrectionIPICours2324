using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    public enum EnumColor { GREEN, ORANGE, RED }
    public class Exercice6
    {

        public void Exercice(EnumColor color)
        {
            int colorInt = (int) color;
            //colorInt = (colorInt + 1) % Enum.GetNames<EnumColor>().Length;
            colorInt = (colorInt + 1) % 3;
            Console.WriteLine(((EnumColor)colorInt).ToString());
        }
    }
}
