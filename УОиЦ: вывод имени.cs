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
            string name;
            string frameLine = "";
            string space = " "; 
            char symbol;

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ: ");
            symbol = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nДлина имени {name} {name.Length}. Длина символа {symbol} 1.");

           int LenghtOfsecondLine = 1 + space.Length + name.Length + space.Length + 1; 

            for (int i = 0; i < LenghtOfsecondLine; i++)
            {
                frameLine += symbol;
            }
            Console.WriteLine(frameLine);
            Console.WriteLine(symbol + space + name + space + symbol);
            Console.WriteLine(frameLine);
        }
    }
}
