namespace IF_ELSE._Конструкция_логического_выбора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  if(Утверждение или выражение) 
             *  {
             *      Действие 1
             *  }
             * else
             * {
             *      Действие 2
             * }
             * 
             * else if { }
             */

            bool isWeapon = false;

            if(isWeapon)
            {
                Console.WriteLine("Вы держите оружие");
            }
            else
            {
                Console.WriteLine("Вы безоружны");
            }
        }
    }
}