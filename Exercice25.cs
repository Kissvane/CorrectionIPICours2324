using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    internal class Exercice25
    {
        public void Exercice()
        {
            HashSet<int> hashset = new HashSet<int>();
            List<int> list = new List<int>();
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                hashset.Add(i);
            }
            sw.Stop();
            Console.WriteLine($"Add in hashset {sw.ElapsedMilliseconds}");
            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i);
            }
            sw.Stop();
            Console.WriteLine($"Add in list {sw.ElapsedMilliseconds}");

            sw.Restart();
            hashset.Contains(900000);
            sw.Stop();
            Console.WriteLine($"search in hashset {sw.ElapsedMilliseconds}");
            
            sw.Restart();
            list.Contains(900000);
            sw.Stop();
            Console.WriteLine($"search in list {sw.ElapsedMilliseconds}");
        }
    }
}
