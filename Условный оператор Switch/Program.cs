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
                    { //Внутри кейсов можно использовать скобки для отделения большого к-ва кода
                        Console.WriteLine("Вы ввели число " + a);
                    }
                    break;

                // Если значение переменной 1 или 3
                case 3://Попадание в этот кейс
                case 2://автоматом переход в этот и выполняется код в нём
                    Console.WriteLine("Вы ввели число " + a);
                    break;//конец кейсов 3 и 2
                default:
                    Console.WriteLine("Введите либо единицу либо двойку!");
                    break;
            }
            /*Если switch не находит совпадений в своих кейсах с тем, что мы ему передали, то он ничего не будет делать и просто пропустит код,НО!!!
              Блок default позволит выполнить определённые операции с входными данными, даже если они не соответствуют кейсам!
             */


            //Использование switch со строками
            Console.WriteLine("Введите знак:");
            string s = Console.ReadLine();

            switch (s)
            {
                case "+":
                    Console.WriteLine("Вы ввели плюс");
                    break;
                case "-":
                    Console.WriteLine("Вы ввели минус");
                    break;
                default:
                    Console.WriteLine("Неизвестный знак");
                    break;
            }
        }
    }
}