using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ2_Сумма_и_произведение_3х_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string str;

            Console.WriteLine(" Сумма и произведение трёх чисел ");
            Console.WriteLine("Введите первое число: ");
            str = Console.ReadLine();

            bool result = Double.TryParse(str, out a);
        }
    }
}
