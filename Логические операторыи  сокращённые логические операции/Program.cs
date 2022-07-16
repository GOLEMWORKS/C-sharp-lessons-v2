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
            bool isTemperature = true;
            bool isCooling = true;

            if(isTemperature && isCooling)
            {
                Console.WriteLine(" Замечен высокий показатель температуры прибора! ");
            }

            Console.ReadLine();
        }
    }
}