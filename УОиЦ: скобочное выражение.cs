using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int bracketsCount = 0;
            int bracketsDepth = 0;
            string bracketsInput;
            bool isExit = false;

            Console.WriteLine("Введите строку со скобками");
            bracketsInput = Console.ReadLine();

            for (int i = 0; i < bracketsInput.Length; i++)
            {
                if (bracketsInput[i] == '(')
                {
                    bracketsCount++;
                }

                else if (bracketsInput[i] == ')')
                {
                    bracketsCount--;

                    if (bracketsCount < 0)
                    {
                        Console.WriteLine("Строка некорректна");
                        isExit = true;
                        break;
                    }
                }

                if (bracketsCount > bracketsDepth)
                {
                    bracketsDepth = bracketsCount;
                }
            }

            if (bracketsCount > 0)
            {
                Console.WriteLine("Строка некорректна");
                isExit = true;
            }

            if (isExit == false)
            {
                Console.WriteLine($"Строка корректна. Максимальная глубина {bracketsDepth}");
            }
        }
    }
}
