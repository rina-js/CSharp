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
            int goldAmount;
            int numberOfCrystals;
            int crystalsToBuy;
            int crystalPrice = 10;

            Console.Write("Введите количество золота: ");
            goldAmount = Convert.ToInt32(Console.ReadLine());
            numberOfCrystals = goldAmount / crystalPrice;
            Console.Write($"При цене кристалла {crystalPrice} вам доступно {numberOfCrystals} кристаллов. Сколько кристаллов хотите купить? ");
            crystalsToBuy = Convert.ToInt32(Console.ReadLine());
            goldAmount -= crystalsToBuy * crystalPrice;
            numberOfCrystals -= crystalsToBuy;
            Console.WriteLine($"Вами куплено {crystalsToBuy} кристаллов. Остаток золота: {goldAmount}. Доступно для покупки {numberOfCrystals} кристаллов.");
        }
    }
}
