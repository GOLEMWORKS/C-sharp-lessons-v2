namespace VAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var не является типом данных и служит для того, чтобы компилятор мог сам присвоить переменной определённый тип
           
            var i = 5; //Целое число типа int
            var s = "qweqe"; // Строка
            var a = new float[12]; //Массив типа float

            Console.WriteLine(i.GetType() + " " +
                              s.GetType() + " " +
                              a.GetType() + " " );
        }
    }
}