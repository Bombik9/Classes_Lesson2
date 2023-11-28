using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Invoice
    {

        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Требуется: 
        //Создать класс Invoice.
        //    В теле класса создать три поля int account, string customer, string provider,
        //    которые должны быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
        //    В теле класса создать два закрытых поля string article, int quantity
        //    Создать метод расчета стоимости заказа с НДС и без НДС.
        //    Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

        public readonly int Account;
        public readonly string Customer, Provider;

        private string article;
        private int quantity;

        double result;
        double nds = 0.2;


        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        public int Quantity { get { return quantity; } set {  quantity = value; } }


        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            
            
        }

        public void Method()
        {
            result = Account + (Account * nds);

        }

        public void Show()
        {
            Console.WriteLine($"{Customer} замовив у {Provider} \n{quantity} {article}  \nРахунок до сплати: \nСума {Account} грн без Ндс  \n{result} грн з Ндс");


        }

    }
}
