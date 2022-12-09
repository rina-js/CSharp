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
            string name = "Petrov";
            string surname = "Alexey";
            string change;
            Console.WriteLine($"Имя {name}, фамилия {surname}.");
            change = name;
            name = surname;
            surname = change;
            Console.WriteLine($"Имя {name}, фамилия {surname}.");
        }
    }
}
