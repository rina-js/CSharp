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
            int peopleInLine;
            int hoursToWait;
            int minutesToWait;
            int waitingTime;
            int visitTimePerOne = 10;
            int minutesInOneHour = 60;

            Console.Write("Введите количество людей в очереди: ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            waitingTime = peopleInLine * visitTimePerOne;
            hoursToWait = waitingTime / minutesInOneHour;
            minutesToWait = waitingTime % minutesInOneHour;
            Console.WriteLine($"Вы должны отстоять в очереди {hoursToWait} часа и {minutesToWait} минут."); 
        }
    }
}
