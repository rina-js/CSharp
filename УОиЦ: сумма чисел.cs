using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int divisor1 = 3;
            int divisor2 = 5;
            int minNumber = 0;
            int maxNumber = 100;
            int positiveNumber;
            int sum = minNumber;
            int randomNumber = random.Next(minNumber, maxNumber);

            Console.WriteLine(randomNumber);

            for (positiveNumber = 0; positiveNumber <= randomNumber; positiveNumber++)
            {
               if (positiveNumber % divisor1 == 0 || positiveNumber % divisor2 == 0)
               {
                    sum += positiveNumber;
               }
            }
            Console.WriteLine(sum);
        }      
    }
}
