using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullRows, picsWithoutRow;
            int numberOfPics = 52;
            int picsInRow = 3;
            fullRows = numberOfPics / picsInRow;
            picsWithoutRow = numberOfPics % picsInRow;
            Console.WriteLine($"Полностью заполненных рядов {fullRows}. Картинок сверх меры {picsWithoutRow}.");
        }
    }
}
