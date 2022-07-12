using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ1_Среднее_арифметическое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;

            Console.WriteLine("Введите первое число: ");
            str = Console.ReadLine();

            bool result = int.TryParse(str, out a);
            if(result)
            {
                Console.WriteLine("Введите второе число: ");
                str = Console.ReadLine();

                bool inresult = int.TryParse(str, out b);
                if(inresult) 
                {
                    double sar = ((double)a + (double)b) / 2;
                    Console.WriteLine("Среднее арифметическое ваших чиесл = " + sar);
                }
                else
                {
                    Console.WriteLine(str + " - не может быть преобразовано в тип int");
                }
            }
            else
            {
                Console.WriteLine(str + " - не может быть преобразовано в тип int");
            }
        }
    }
}
