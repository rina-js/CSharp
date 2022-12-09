using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minExceedNumber = 1;
            int minRandomNumber = 0; 
            int maxRandomNumber = 10000; 
            int baseNumber = 2;
            int powerOfBaseNumber = 0;
            int randomNumber = random.Next(minRandomNumber, maxRandomNumber);

            Console.WriteLine($"Рандомное число: {randomNumber}");

            while (minExceedNumber <= randomNumber)
            {
                minExceedNumber *= baseNumber;
               
                if (minExceedNumber % baseNumber == 0)
                {
                    powerOfBaseNumber++;
                }
            }
            Console.WriteLine($"Минимально превосходящее число: {minExceedNumber}");
            Console.WriteLine($"Степень двойки: {powerOfBaseNumber}");
        }
    }
}
