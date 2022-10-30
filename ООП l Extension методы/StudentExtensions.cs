using ООП_l_Extension_методы; //Для отображения класса подключаем namespace с ним

namespace ООП_l_Extension_методы_Student_Extensions
{
    static class StudentExtensions
    {
        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
