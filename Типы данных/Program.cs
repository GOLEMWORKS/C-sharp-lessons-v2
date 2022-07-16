using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Типы_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Типы данных в C#";

            Console.WriteLine("Целые типы: sbyte, byte, short, ushort, int, uint, long, ulong." +
                "\n\nТипы, в которых сохраняются данные с плавающей запятой(соответствуют вещественному типу): float, double, decimal." +
                "\n\nСимвольный тип: char." +
                "\n\nЛогический тип: bool." +
                "\n\nСтрочный тип: string.");

            //Cтоит всегда учитывать размер памяти каждой комманды, выполняемой программой для лучшей производительности и меньшего веса!
            Console.WriteLine("\nДля определения размера переменной заданного типа используется sizeof():");

            int d;
            d = sizeof(sbyte); // d = 1
            Console.WriteLine("sbyte:" + d);

            d = sizeof(short); // d = 2
            Console.WriteLine("short:" + d);

            d = sizeof(int);   // d = 4
            Console.WriteLine("int:" + d);

            d = sizeof(long);  // d = 8
            Console.WriteLine("long:" + d);

            Console.WriteLine("\nОпределение минимального и максимального значения производится через .MaxValue");

            int MaxI;
            int MinI;

            MaxI = int.MaxValue; // MaxI =  2147483647
            Console.WriteLine("Максимальное значение: " + MaxI);

            MinI = int.MinValue; // MinI = -2147483648
            Console.WriteLine("Минимальное значение: " + MinI);
        }
    }
}
