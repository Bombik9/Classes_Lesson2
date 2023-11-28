using System.Threading.Channels;
using task6;

namespace Classes_Lesson2
{
    internal class Program
    {



            static void Main(string[] args)
            {
                //Используя Visual Studio, создайте проект по шаблону Console Application. 
                //    Требуется: 
                //Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата заполнения анкеты). 
                //    Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
                //    Реализуйте вывод на экран информации о пользователе.

               User user = new User();

                user.Login = "Bombik";
    
                user.Name = "Oleksandr";
  
                user.Surname = "Bobik";

                user.Age = 29;

                

                user.Show();

                

             

                Console.ReadKey();

            }
        
    }
}