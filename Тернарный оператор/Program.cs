namespace Тернарный_оператор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Тернарный оператор выполняет операции над тремя операторами

            // [Первый операнд - условие] ? [Второй операнд if_true] : [третий операнд if_false] - логика как у if else

            bool accessAllowed;

            string storedPassword = "123";
            string enteredPassword = Console.ReadLine();

            //Более удобный и компактный способ заменить if else
            accessAllowed = enteredPassword == storedPassword ? true : false;

            Console.WriteLine(accessAllowed + "\n");

            Console.WriteLine("Вывод только положительных чисел! Введите число: ");
            while (true)//Если переменные внутри цикла, то они могут быть использованы после блока try cath, в ином случае их не определяет вне его
            {
                int num, data;

                try
                {
                    Console.WriteLine("Введите число:");
                    data = int.Parse(Console.ReadLine());
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный тип данных!");
                    Console.ReadLine();
                    continue;
                }

                num = (data >= 0) ? data : 0; //Скобки необязательны, но удобны для понимания кода
                Console.WriteLine(num);
                Console.ReadLine();
            } 
        }
    }
}