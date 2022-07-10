using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //Для ввода чисел с запятой

namespace Конвертация_типов_данных__Перевод_строки_в_число._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер интересующего вас задания:" +
                "\n1 - Вычислительные операции с двумя указанными целыми числами" + 
                "\n2 - Ввод десятчной дроби в консоль");
            string ch = Console.ReadLine();

            if (ch == "1")
            {
                //конвертация строки в другие типы данных

                string str;
                int a, b;


                try
                {
                    Console.WriteLine("Введите первое число:");
                    str = Console.ReadLine();

                    a = Convert.ToInt32(str);


                    Console.WriteLine("Введите второе число:");
                    str = Console.ReadLine();

                    b = Convert.ToInt32(str);

                    int sum = a + b;
                    int dif = a - b;
                    int mul = a * b;
                    int div = a / b;


                    //При сложения строки с чем-либо, происходик конкатинация и нестрочный элемент становится строкой!
                    Console.WriteLine("Действия с числами " + a + " и " + b + ":" +
                        "\n Сумма: " + sum +
                        "\n Разность: " + dif +
                        "\n Произведение: " + mul +
                        "\n Целочисленное частное: " + div);
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("Неверные символы. Введите целое число!");
                }
                catch (System.DivideByZeroException)
                {
                    Console.WriteLine("Второе число не может быть нулём!");
                }

            } 
            
            else if (ch == "2") 
            
            { 
                //ввод данных типа double (С точкой)
                Console.WriteLine("\nВведите десятичную дробь через точку или запятую:");
                string str2 = Console.ReadLine();


                /*
                 * Из-за разной настройки ОС время, дата и разделительные знаки отображаются по разному, 
                 * поэтому используется данный класс. Он позволяет указать новый(е) разделительный знак(и)
                 * для десятичных дробей, которые будут использоваться методом Convert.
                */
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };

                try 
                { 
                    double dou = Convert.ToDouble(str2, numberFormatInfo);  //Указываем что хотим вывести и экземпляр класса NumberFormatInfo
                    Console.WriteLine("Ваша десятичная дробь:" + str2);
                } 
                catch (System.FormatException)//Ошибка при неверном введении
                {
                    Console.WriteLine("Введите точку или запятую как символ разделения целой и дробной частей!");
                }
            }

            else 
            {
                Console.WriteLine("\nМне не известно данное задание :(");
            }
        }
    }
}
