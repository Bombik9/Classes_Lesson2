using System.Text;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Используя Visual Studio, создайте проект по шаблону Console Application. 
            //        Требуется:
            //    Создать класс Employee.
            //        В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
            //        Создать метод рассчитывающий оклад сотрудника(в зависимости от должности и стажа) и налоговый сбор.
            //        Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор. 
            Console.OutputEncoding = Encoding.Unicode;
            Employee employee = new Employee();
            

            employee.Name = "Олександр";
            employee.Surname = "Бобік";
            employee.Salary = 10000;
            employee.Position = "Електрик";
            employee.WorkAge = 5;
            employee.Show();
            employee.Method();

           

            Console.WriteLine(new string('-', 50));

            Employee employee1 = new Employee();
            employee1.Name = "Олег";
            employee1.Surname = "Осипенко";
            employee1.Salary = 12000;
            employee1.Position = "Водій";
            employee1.WorkAge = 13;
            employee1.Show();
            employee1.Method();

            

            Console.ReadKey();

        }
    }
}