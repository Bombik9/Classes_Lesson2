using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class User
    { 

        string login, name, surname;
        int age;
        public readonly string date = "date";

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {

            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Show()
        {

            Console.WriteLine(Login);
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Age);
            Console.WriteLine(date);

        }


        // Конструктор.
        public User()
        {
            date = "22.11.2023";

        }

    }
}
