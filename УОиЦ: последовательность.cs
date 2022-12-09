using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 5;
            int maxValue = 96;
            int step = 7;

            for (int i = minValue; i <= maxValue; i += step) // цикл for, т.к. в задаче даны числовые параметры (начальное и конечное значения, шаг изменения последовательности)
            {
                Console.WriteLine(i);
            }
        }
    }
}
