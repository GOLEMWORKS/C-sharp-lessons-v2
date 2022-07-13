using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ3_Конвертер_валют_на_хардкоде
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Конвертер валют RUB <-> USD";


            string str;
            double rub, usd;


            Console.WriteLine("Введите 1, если хотите перевести RUB в USD" +
                              "\nВведите 2, если хотите перевести USD в RUB");

            str = Console.ReadLine();

            if (str == "1")
            {
                Console.WriteLine("Введите количество рублей(rub): ");

                str = Console.ReadLine();
                bool convertru = double.TryParse(str, out rub);

                if(convertru)
                {
                    usd = rub / 65;
                    Console.WriteLine("За " + rub + " рублей вы получите " + usd + " долларов США");
                }
                
                else
                {
                    Console.WriteLine("Неверный формат введённых данных!");
                }
            }

            else if (str == "2")
            {
                Console.WriteLine("Введите количество долларов США(usd): ");

                str = Console.ReadLine();
                bool convertur = double.TryParse(str, out usd);

                if(convertur)
                {
                    rub = usd * 65;
                    Console.WriteLine("За " + usd + " долларов США вы получите " + rub + " рублей");
                }

                else
                {
                    Console.WriteLine("Неверный формат введённых данных!");
                }
            }

            else
            {
                Console.WriteLine("Неизвестная команда!");
            }
        }
    }
}
