
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int numberOfMessages;

            Console.Write("Введите сообщение: ");
            message = Console.ReadLine();
            Console.Write("Введите количество повторов сообщения: ");
            numberOfMessages = Convert.ToInt32(Console.ReadLine());

             for (int i = numberOfMessages; i > 0; i--)
            {
                Console.WriteLine(message);
            }
        }
    }
}
