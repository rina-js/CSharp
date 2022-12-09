using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string exit = "exit";
            bool isExit = false;
            float currencyCount;
            float rubBalance = 567f;
            float usdBalance = 478f;
            float eurBalance = 392f;
            float rubToUsd = 0.015f;
            float usdToRub = 65.79f;
            float rubToEur = 0.014f;
            float eurToRub = 71.68f;
            float usdToEur = 0.93f;
            float eurToUsd = 1.07f;

            while (isExit == false)
            {
                Console.WriteLine($"Ваш баланс {rubBalance} рублей, {usdBalance} долларов и {eurBalance} евро.");
                Console.WriteLine("Для конвертации рублей в доллары введите 1");
                Console.WriteLine("Для конвертации долларов в рубли введите 2");
                Console.WriteLine("Для конвертации рублей в евро введите 3");
                Console.WriteLine("Для конвертации евро в рубли введите 4");
                Console.WriteLine("Для конвертации долларов в евро введите 5");
                Console.WriteLine("Для конвертации евро в доллары введите 6");
                Console.WriteLine("Для выхода введите exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Сколько рублей хотите перевести в доллары?");
                        userInput = Console.ReadLine();
                        currencyCount = Convert.ToSingle(userInput);

                        if (rubBalance >= currencyCount)
                        {
                            rubBalance -= currencyCount;
                            usdBalance += currencyCount * rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый баланс рублей.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Сколько долларов хотите перевести в рубли?");
                        userInput = Console.ReadLine();
                        currencyCount = Convert.ToSingle(userInput);

                        if (usdBalance >= currencyCount)
                        {
                            usdBalance -= currencyCount;
                            rubBalance += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый баланс долларов.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Сколько рублей хотите перевести в евро?");
                        userInput = Console.ReadLine();
                        currencyCount = Convert.ToSingle(userInput);

                        if (rubBalance >= currencyCount)
                        {
                            rubBalance -= currencyCount;
                            eurBalance += currencyCount * rubToEur;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый баланс рублей.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Сколько евро хотите перевести в рубли?");
                        userInput = Console.ReadLine();
                        currencyCount = Convert.ToSingle(userInput);

                        if (eurBalance >= currencyCount)
                        {
                            eurBalance -= currencyCount;
                            rubBalance += currencyCount * eurToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый баланс евро.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Сколько долларов хотите перевести в евро?");
                        userInput = Console.ReadLine();
                        currencyCount = Convert.ToSingle(userInput);

                        if (usdBalance >= currencyCount)
                        {
                            usdBalance -= currencyCount;
                            eurBalance += currencyCount * usdToEur;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый баланс долларов.");
                        }
                        break;

                    case "6":
                        Console.WriteLine("Сколько евро хотите перевести в доллары?");
                        userInput = Console.ReadLine();
                        currencyCount = Convert.ToSingle(userInput);

                        if (eurBalance >= currencyCount)
                        {
                            eurBalance -= currencyCount;
                            usdBalance += currencyCount * eurToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый баланс евро.");
                        }
                        break;

                    case "exit":
                        isExit = true;
                        break;
                }
            }
        }
    }
}
