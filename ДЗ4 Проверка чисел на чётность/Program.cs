namespace ДЗ4_Проверка_чисел_на_чётность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a;

            Console.WriteLine("Введите целое число:");
            
            str = Console.ReadLine();

            bool result = int.TryParse(str, out a);
            
            if (result)
            {

                if(a % 2 == 0)
                {
                    Console.WriteLine("Число чётное");
                }
                
                else
                {
                    Console.WriteLine("Число не чётное");
                }
            }

            else
            {
                Console.WriteLine("Вы ввели не целое число");
            }
        }
    }
}