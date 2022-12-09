using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string input;
            int minHealth = 0;
            int bossHealth = random.Next(200, 600);
            int mageHealth = random.Next(300, 500);
            int bossDamage;
            int minBossDamage = 80;
            int maxBossDamage = 180;
            int blackBoxDamage = 50;
            int raccoonDamage = 150;
            int minHealthToHide = 200;
            int healthRestore = 100;
            int mageGrungeDamage = 80;
            int bossGrungeDamage = 180;
            bool isRaccoonCage = false;
            bool isRaccoonSpell = false;

            Console.WriteLine("Вам доступны заклинания:");
            Console.WriteLine($"Черный ящик - приобретает клетку с енотом. Урон теневому магу - {blackBoxDamage} ед.");
            Console.WriteLine($"Раккон - выпускает боевого енота и наносит {raccoonDamage} ед. урона боссу. Доступно после приобретения клетки с енотом");
            Console.WriteLine($"Скрыться - позволяет скрыться от удара и восстановить {healthRestore} хп, если здоровье теневого мага меньше {minHealthToHide} хп");
            Console.WriteLine($"Гранж - оглушает и ослепляет босса и вас, наносит боссу {bossGrungeDamage} ед. урона, вам - {mageGrungeDamage} ед. урона. Доступно после применения заклинания Раккон");
            Console.WriteLine($"\nЗдоровье босса {bossHealth} хп, здоровье теневого мага {mageHealth} хп");

            while (bossHealth > minHealth && mageHealth > minHealth)
            {
                Console.Write("Введите заклинание: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "Черный ящик":
                        isRaccoonCage = true;
                        mageHealth -= blackBoxDamage;
                        Console.WriteLine($"Теперь у мага есть клетка с енотом за -{blackBoxDamage} хп. Здоровье мага уменьшено до {mageHealth} хп.");
                        bossDamage = random.Next(minBossDamage, maxBossDamage);
                        mageHealth -= bossDamage;
                        Console.WriteLine($"Босс наносит удар на {bossDamage} ед. урона. Здоровье мага {mageHealth} хп.");
                        break;

                    case "Раккон":
                        if (isRaccoonCage == true)
                        {
                            isRaccoonSpell = true;
                            bossHealth -= raccoonDamage;
                            Console.WriteLine($"У босса отнято {raccoonDamage} хп. Здоровье босса {bossHealth} хп.");
                            bossDamage = random.Next(minBossDamage, maxBossDamage);
                            mageHealth -= bossDamage;
                            Console.WriteLine($"Босс наносит удар {bossDamage} ед. урона. Здоровье мага {mageHealth} хп.");
                        }
                        else
                        {
                            Console.WriteLine("Заклинание Раккон не применено из-за отсутствия клетки с енотом");
                        }
                        break;

                    case "Скрыться":
                        if (mageHealth < minHealthToHide)
                        {
                            mageHealth += healthRestore;
                            Console.WriteLine($"Заклинание Скрыться применено, у мага восстановлено {healthRestore} хп. Здоровье мага {mageHealth} хп. ");
                        }
                        else
                        {
                            Console.WriteLine("Здоровье мага больше 200 хп, заклинание не может быть применено.");
                        }
                        break;

                    case "Гранж":
                        if (isRaccoonSpell == true)
                        {
                            bossHealth -= bossGrungeDamage;
                            mageHealth -= mageGrungeDamage;
                            Console.WriteLine($"Маг получил урон {mageGrungeDamage} ед., босс получил урон {bossGrungeDamage} ед.\nЗдоровье мага {mageHealth} хп. Здоровье босса {bossHealth} хп.");
                        }
                        else
                        {
                            Console.WriteLine("Заклинание Гранж не применено из-за того, что заклинание Раккон не было применено ранее");
                        }
                        break;
                }
            }

            if (bossHealth <= minHealth)
            {
                Console.WriteLine("Босс мертв");
            }

            else if (bossHealth <= minHealth && mageHealth <= minHealth)
            {
                Console.WriteLine("Оба мертвы, ничья.");
            }

            else if (mageHealth <= minHealth)
            {
                Console.WriteLine("Маг умер");
            }
        }
    }
}
