namespace Методы_и_функции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Функция не существует без класса, а функция которая принадлежит классу - это метод, поэтому функции = метод в C#

            /* 
             Модификатор тип_возвращаемого_значения название_метода(параметры)
                {
                    тело метода
                }
             
             */
            int av, bv, cv;

            try
            {
                av = int.Parse(Console.ReadLine());
                bv = int.Parse(Console.ReadLine());

                cv = Sum(av, bv); //Переменные в методе и при его вызове могут называться по разному!

                PrintResult(cv);
            }
            catch (Exception)
            {
                Console.WriteLine("Введите целые числа!");
            }
        }

        //Создание метода
        static int Sum(int a, int b) // Метод не обязан вызвращать результат, тогда указывается тип возвращаемого значения void
        {
            int res;

            res = a + b; // меняем тут, меняется везде где используется метод

            return res; // Возвращает результат работы, в простых методах можно просто писать return действие;
        }

        static void PrintResult(int result) // Ничего не принимает и возвращает что-то!
        {
            Console.WriteLine("Результат сложения " + result);
        }
    }
}