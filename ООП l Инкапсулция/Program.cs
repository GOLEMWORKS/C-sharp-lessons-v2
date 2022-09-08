namespace ООП_l_Инкапсулция
{
    //Инкапсуляция позволяет удобнее работать с кодом и получать меньше ошибок при его написании
    //Инкапсуляция - защита некоторых частей класса от вмешательства из вне. Работа с ними проходит
    //Опосредовано через public методы и переменные
    class Shotgun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Зарядка патрона...");

            isLoaded = true;

            Console.WriteLine("Патрон заряжен!");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Перезаряжаюсь!");
                    Reload();
            }

            Console.WriteLine("Выстрел");
            isLoaded = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var shotgun = new Shotgun();
            shotgun.Shoot();
        }
    }
}