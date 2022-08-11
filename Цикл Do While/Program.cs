namespace Цикл_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цикл do while и его особенности
            Console.WriteLine("DO WHILE");
           /* while (true)
            {
                Сначала проверяет условие, а потом выполняет действие
            }
           */
            int count = 5;

            do
            {
                //Сначала выполняет действие, а потом проверяет условие 
                //Выполняется всегда хотябы один раз!
                count++;
                Console.WriteLine(count); //Выведет 6
            } while (count < 5);
        }
    }
}