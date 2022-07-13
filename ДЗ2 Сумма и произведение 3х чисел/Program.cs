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

            bool result = double.TryParse(str, out a);
            
            if(result)
            {
                Console.WriteLine("Введите второе число: ");
                str = Console.ReadLine();

                bool inres1 = double.TryParse(str, out b);

                if (inres1) 
                {
                    Console.WriteLine("Введите третье число: ");
                    str = Console.ReadLine();

                    bool inres2 = double.TryParse(str, out c);

                    if (inres2)
                    {
                        double sum, mult, dif, div;

                        sum = a + b + c;
                        mult = a * b * c;
                        dif = a - b - c;
                        div = a / b / c;

                        Console.WriteLine("Сумма чисел: " + sum + "\nПроизведение чисел: " + mult);
                    }

                    else

                    {
                        Console.WriteLine("Строка со значением " + str + " не является числом!");
                    }
                }

                else
                {
                    Console.WriteLine("Строка со значением " + str + " не является числом!");
                }
            }

            else

            {
                Console.WriteLine("Строка со значением " + str + " не является числом!");
            }
        }
    }
}
