namespace ДЗ5._2_Калькулятор_на_switch_другая_проверка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();//очистка консоли после отработки цикла!
                double a, b;
                string s;

                try
                {
                    Console.WriteLine("Введите первое число:");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    b = double.Parse(Console.ReadLine());

                }

                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать введённые данные в чило, попробуйте снова!");
                    Console.ReadLine();
                    continue; // После этого слова код далее выполняться не будет и цикл while начнётся заново

                }

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                s = Console.ReadLine();

                switch(s)
                {
                    case "+":
                        Console.WriteLine("Сумма чисел = " + (a + b));
                        break;

                    case "-":
                        Console.WriteLine("Разность чисел = " + (a - b));
                        break;

                    case "*":
                        Console.WriteLine("Произведение чисел = " + (a * b));
                        break;

                    case "/":
                        if (b == 0)
                            Console.WriteLine("Деление на ноль невозможно!");
                        else
                            Console.WriteLine("Частное чисел = " + (a / b));
                            break;


                    default:
                        Console.WriteLine("Неизвестное действие, попробуйте снова!");
                        Console.ReadLine();
                        break;        
                }


                Console.ReadLine();
            }
        }
    }
}