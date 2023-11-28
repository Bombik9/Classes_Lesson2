using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Employee
    {//    Используя Visual Studio, создайте проект по шаблону Console Application. 
     //        Требуется:
     //    Создать класс Employee.
     //        В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
     //        Создать метод рассчитывающий оклад сотрудника(в зависимости от должности и стажа) и налоговый сбор.
     //        Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор. 
        string name, surname, position;
        int workAge, salary;
        double result;


        public string Name { get; set; }
        public string Surname { get; set; } 
         public string Position {  get; set; }

        public int Salary { get; set; }
        public int WorkAge { get;set; }
       

        public void Method()
        {
            if ((WorkAge >= 0 ) && (WorkAge < 10))       
            {
                result = Salary * 0.25;
                Console.WriteLine($"Трудовий стаж до {WorkAge} років знімає ПДВ у розмірі {result} грн");

            }

            else if ((WorkAge >= 10) && (WorkAge < 15))
            {
                result = Salary * 0.20;
                Console.WriteLine($"Трудовий стаж до {WorkAge} років знімає ПДВ у розмірі {result} грн ");
            }
            else
            {
                Console.WriteLine("Не вірні данні");
            }
         

        }

        public void Show()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Прізвище: {Surname}");
            Console.WriteLine($"Посада: {Position}");
            Console.WriteLine($"Оклад: {Salary} UAH");
            Console.WriteLine($"Тудовий стаж: {WorkAge} років");
        }

    }
}
