using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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
        private int quamtity;

        double nds = 0.2;
        double result;

        public string Article {  get { return article; } set {  article = value; } }

        public int Quamtity { get {  return quamtity; } set { quamtity = value; } }

       

        public Invoice( int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;    
        }
        
        public void Method()
        {
            result =Account + (Account * nds);
            
        }

        public void Swow()
        {
            Console.WriteLine($"{Customer} замовив у {Provider} {quamtity} {article} і виставив рахунок \n{Account} без НДС і {Method} з НДС");
        }


    }
}
