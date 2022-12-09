using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit;
            string stop = "exit";
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine($"Введите название любого фрукта.Для выхода введите {stop}");
                fruit = Console.ReadLine();

                if (fruit == stop)
                {
                    isExit = true;
                }
            }
        }
    }
}
