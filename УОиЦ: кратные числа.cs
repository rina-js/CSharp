using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int minInputNumber = 1;
            int maxInputNumber = 27;
            int numbersCount = 0;
            int rangeNumber;
            int minRangeNumber = 100;
            int maxRangeNumber = 999;

            Console.WriteLine($"Введите число в диапазоне от {minInputNumber} до {maxInputNumber}");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber >= minInputNumber && inputNumber <= maxInputNumber)
            {
                for (rangeNumber = 0; rangeNumber <= maxRangeNumber; rangeNumber += inputNumber)
                {
                    if (rangeNumber >= minRangeNumber)
                    { 
                        numbersCount++;
                    }
                }

                Console.WriteLine(inputNumber + " " + numbersCount);
            }
            else
            {
                Console.WriteLine("Число вне диапазона");
            }
        }
    }
}
