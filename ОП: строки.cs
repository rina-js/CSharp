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
            string name;
            string age;
            string zodiacSign;
            string workplace;
            Console.Write("Как вас зовут? ");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Console.ReadLine();
            Console.Write("Кто вы по знаку зодиака? ");
            zodiacSign = Console.ReadLine();
            Console.Write("Где вы работаете? ");
            workplace = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {age} год, вы {zodiacSign} и работаете {workplace}.");
        }
    }
}
