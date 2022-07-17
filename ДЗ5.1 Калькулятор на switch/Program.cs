namespace ДЗ5._1_Калькулятор_на_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool res;
            string ins;


            Console.WriteLine("Введите первое число:");
            ins = Console.ReadLine();

            res = double.TryParse(ins, out a);

            if (res)
            {

                Console.WriteLine("Введите вторе число:");
                ins = Console.ReadLine();

                res = double.TryParse(ins, out b);
                if(res)
                {

                    Console.WriteLine("Выберите оператор и введите его в консоль:\n + ; - ; / ; *");
                    ins = Console.ReadLine();

                    switch(ins)
                    {
                        case "+":
                            Console.WriteLine("Сумма чисел: " + (a + b));
                            break;

                        case "-":
                            Console.WriteLine("Разность чисел: " + (a - b));
                            break;

                        case "/":

                            //if и else без фигурных скорок выполнят только одну последующую за ними строчку!
                            if (b != 0)
                                Console.WriteLine("Частное чисел: " + (a / b));
                            else
                                Console.WriteLine("Делитель (Второе число) не может быть равен нулю!");

                            break;

                        case "*":
                            Console.WriteLine("Произведение чисел: " + (a * b));
                            break;

                        default:
                            Console.WriteLine("Вы ввели неверный оператор!");
                            break;
                    }
                }
                
                else
                {
                    Console.WriteLine("Вы ввели некорректный тип данных!");
                }

            }

            else
            {
                Console.WriteLine("Вы ввели некорректный тип данных!");
            }
            Console.ReadLine();
        }
    }
}