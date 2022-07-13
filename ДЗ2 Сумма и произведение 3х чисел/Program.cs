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

            Console.WriteLine("Сумма и произведение трёх чисел ");
            Console.WriteLine("Введите первое число: ");
            str = Console.ReadLine();

            bool result = double.TryParse(str, out a);

            //проверка на возможность перевести строку к типу double
            if (result)
            {
                Console.WriteLine("Введите второе число: ");
                str = Console.ReadLine();

                //Проверка на деление на ноль
                if (str == "0")
                {
                    Console.WriteLine("Данная переменная не может принимать значение 0!");
                }

                else
                {

                    bool inres1 = double.TryParse(str, out b);

                    //проверка на возможность перевести строку к типу double
                    if (inres1)
                    {
                        Console.WriteLine("Введите третье число: ");
                        str = Console.ReadLine();

                        //Проверка на деление на ноль
                        if (str == "0")
                        {
                            Console.WriteLine("Данная переменная не может принимать значение 0!");
                        }

                        else
                        {
                            bool inres2 = double.TryParse(str, out c);
                            //проверка на возможность перевести строку к типу double
                            if (inres2)
                            {
                                double sum, mult, dif, div;

                                sum = a + b + c;
                                mult = a * b * c;
                                dif = a - b - c;
                                div = a / b / c;

                                Console.WriteLine("Сумма чисел: " + sum + "\nПроизведение чисел: " + mult + "\nРазность чисел: " + dif + "\nЧастное чисел: " + div);
                            }

                            else

                            {
                                Console.WriteLine("Строка со значением " + str + " не является числом!");
                            }

                        }

                    }

                    else
                    {
                        Console.WriteLine("Строка со значением " + str + " не является числом!");
                    }
                }
            }
            else

            {
                Console.WriteLine("Строка со значением " + str + " не является числом!");
            }
        }
    }
}
