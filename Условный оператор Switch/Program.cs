namespace Условный_оператор_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                //Если значение переменной a = 1
                case 1:
                    Console.WriteLine("Вы ввели число " + a);
                    break;

                case 2:
                    Console.WriteLine("Вы ввели число " + a);
                    break;
                default:
                    Console.WriteLine("Введите либо единицу либо двойку!");
                    break;
            }
            /*Если switch не находит совпадений в своих кейсах с тем, что мы ему передали, то он ничего не будет делать и просто пропустит код,НО!!!
              Блок default позволит выполнить определённые операции с входными данными, даже если они не соответствуют кейсам!
             */
        }
    }
}