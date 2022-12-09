using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "1a35";
            string secretMessage = "Не шалю, никого не трогаю, починяю примус";
            string userInput;

            for(int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }
                else
                {
                    int attemptsLeft = tryCount - i - 1;
                    Console.WriteLine($"У вас осталось {attemptsLeft} попыток");
                }
            }
        }
    }
}
