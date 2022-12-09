using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userName;
            string inputPassword;
            string inputPhoneNumber;
            string defaultPassword = "1a357";
            string defaultPhoneNumber = "89997725566";
            string exit = "exit";
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Вам доступны следующие действия:");
                Console.WriteLine("Введите CreateNewAccount, чтобы создать новую учетную запить");
                Console.WriteLine("Введите ChangePassword, чтобы войти в учетную запись и сбросить пароль");
                Console.WriteLine("Введите NewPhoneNumber, чтобы привязать номер телефона");
                Console.WriteLine("Введите ChangeConsoleColor, чтобы изменить цвет консоли");
                Console.WriteLine("Введите ChangeUserName, чтобы восстановить имя учетной записи");
                Console.WriteLine("Для выхода введите exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "CreateNewAccount":
                        Console.WriteLine("Введите имя новой учетной записи");
                        userName = Console.ReadLine();
                        Console.WriteLine("Введите пароль новой учетной записи");
                        inputPassword = Console.ReadLine();
                        Console.WriteLine($"Вы успешно создали новую учетную запись {userName}");
                        break;

                    case "ChangePassword":
                        Console.WriteLine("Введите пароль текущей учетной записи");
                        inputPassword = Console.ReadLine();

                        if (inputPassword == defaultPassword)
                        {
                            Console.WriteLine("Вход выполнен. Введите новый пароль для текущей учетной записи");
                            inputPassword = Console.ReadLine();
                            Console.WriteLine($"Вы успешно установили новый пароль {inputPassword}");
                        }
                        else
                        {
                            Console.WriteLine("Не удалось выполнить вход в учетную запись.");
                        }
                        break;

                    case "NewPhoneNumber": 
                        Console.WriteLine("Введите номер телефона, привязанный к учетной записи ранее");
                        inputPhoneNumber = Console.ReadLine();

                        if (inputPhoneNumber == defaultPhoneNumber)
                        {
                            Console.WriteLine("Номер найден. Введите новый номер, к которому хотите привязать учетную запись");
                            inputPhoneNumber = Console.ReadLine();
                            Console.WriteLine($"Вы успешно привязали новый номер {inputPhoneNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Не удалось найти введенный номер телефона.");
                        }
                        break;

                    case "ChangeConsoleColor": 
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;

                    case "ChangeUserName": 
                        Console.WriteLine("Введите номер телефона, привязанный к учетной записи");
                        inputPhoneNumber = Console.ReadLine();

                        if (inputPhoneNumber == defaultPhoneNumber)
                        {
                            Console.WriteLine("Номер телефона найден. Введите пароль");
                            inputPassword = Console.ReadLine();

                            if (inputPassword == defaultPassword)
                            {
                                Console.WriteLine("Вход выполнен. Введите новое имя учетной записи");
                                userName = Console.ReadLine();
                                Console.WriteLine($"Вы успешно изменили имя учетной записи на {userName}");
                            }
                            else
                            {
                                Console.WriteLine("Вход не выполнен. Пароль введен неверно");
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Введенный номер не привязан к учетной записи");
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
