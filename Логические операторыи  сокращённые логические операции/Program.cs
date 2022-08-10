namespace Логические_операторыи__сокращённые_логические_операции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                                        Логические операторы 
                                        
                                        && - Сокращённое И
                                        || - Сокращённое ИЛИ
                                              & - И
                                             | - ИЛИ
                                           ! - Не (Унарный)
             
            */

            // Не:
            bool isWeapon = false;


            //if работает со значением true, поэтому чтобы не писаль else мы ставим унарный НЕ " ! " и полу
            if(!isWeapon)
            {
                Console.WriteLine(" Не является оружием ");
            }


            //Cокращённый И " && "
            double temp, speed;
            temp = 190.21; //температура
            speed = 2902; //обороты
           
            bool isTemperature = temp >= 100;
            bool isCooling =  speed <= 2000;

            //Работает только когда оба элемента имеют значение true
            if(isTemperature && isCooling)
            {
                Console.WriteLine(" Сбой в работе прибора! ");
            }
            //Аналогичная программка с сокращённым или ||. Активируется когда один из элементов true
            if (isTemperature || isCooling)
            {
                Console.WriteLine(" Сбой в работе прибора! isTemperature: " + isTemperature + " , isCooling: " + isCooling);
            }
            /*Cокращённые и не сокращённые отличаются тем, что первые не проверяют вторую часть условия, если в этом нет необходимости.
              Не сокращённые версии использвуются редко из-за специфики их работы и большего времени на обработку!  
            */


            Console.ReadLine();
        }
    }
}